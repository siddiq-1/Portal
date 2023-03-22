using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portal.DTO;
using Portal.SERVICE.IService;
using Portal.UTILITY;

namespace Portal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        readonly IAuthenticationService _authenticateSerivce;
        public AccountController(IAuthenticationService authenticationService)
        {
            _authenticateSerivce= authenticationService;
        }
        [HttpPost("GetAuthenticate")]
        public async Task<ServiceResult<SignUpModelDTO>> GetAuthenticate([FromBody] LoginModelDTO loginModelDTO)
        {
            ServiceResult<SignUpModelDTO> serviceResult = new ServiceResult<SignUpModelDTO>();
            try
            {
                var authResult = await _authenticateSerivce.AuthenticateUser(loginModelDTO);
                if(authResult != null)
                {
                    var token = _authenticateSerivce.GetToken(authResult);
                   serviceResult.Success(token);
                }
            }
            catch (Exception ex)
            {
                serviceResult.Failure(ex.Message);
            }
            return serviceResult;
        }
    }
}
