using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.IdentityModel.Tokens;
using Portal.API;
using Portal.API.Controllers.Admins;
using Portal.DATA;
using Portal.DATA.IRepository;
using Portal.DATA.Repository;
using Portal.SERVICE.IService;
using Portal.SERVICE.Service;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<PortalContext>(options => options.UseSqlServer(builder.Configuration["defaultConnections"]));
builder.Services.TryAddScoped<IUserService, UserService>();
builder.Services.TryAddScoped<ICandidateService, CandidateService>();
builder.Services.TryAddScoped<IAdminService, AdminService>();
builder.Services.TryAddScoped<IRecruiterService, RecruiterService>();
builder.Services.TryAddScoped<IJobService, JobService>();
builder.Services.TryAddScoped<IUserRepository, UserRepository>();
builder.Services.TryAddScoped<ICandidateRepository, CandidateRepository>();
builder.Services.TryAddScoped<IAdminRepository, AdminRepository>();
builder.Services.TryAddScoped<IRecruitersRepository, RecruitersRepository>();
builder.Services.TryAddScoped<IJobsRepository, JobRepository>();
builder.Services.TryAddScoped<IAuthenticationService, AuthenticationService>();
builder.Services.TryAddScoped<IAuthenticationRepository, AuthenticationRepository>();
builder.Services.TryAddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidateAudience= true,
        ValidateLifetime = true,    
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        ValidAudience = builder.Configuration["Jwt:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
    };
    });

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
