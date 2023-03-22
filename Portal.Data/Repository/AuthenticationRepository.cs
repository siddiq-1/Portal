using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Portal.DATA.IRepository;
using Portal.DTO;
using Portal.MODEL;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Portal.DATA.Repository
{
    public class AuthenticationRepository : IAuthenticationRepository
    {
        readonly IConfiguration _config;
        readonly IUserRepository _userRepository;
        public AuthenticationRepository(IConfiguration config , IUserRepository userRepository)
        {
            _config = config;
            _userRepository = userRepository;
        }
        public string GenerateToken(SignUpModelDTO signUpModelDTO )
        {
            var symetricKey =  new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(symetricKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier,signUpModelDTO.Username),
                new Claim(ClaimTypes.Email, signUpModelDTO.Email),
                new Claim(ClaimTypes.GivenName,signUpModelDTO.Name),
                new Claim(ClaimTypes.Role,signUpModelDTO.Role)
            };

            var token  = new JwtSecurityToken(_config["Jwt:Issuer"],
                _config["Jwt:Audience"],claims , expires: DateTime.Now.AddMinutes(15),signingCredentials:credentials);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public async Task<UserModel> ValidateUser(LoginModelDTO loginModelDTO)
        {
            var LoginModelReult = await _userRepository.FindUserByPredicate(model => model.Username == loginModelDTO.Username && model.Password == loginModelDTO.Password);

            return LoginModelReult;
        }
    }
}
