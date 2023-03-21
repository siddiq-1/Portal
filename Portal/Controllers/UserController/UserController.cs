using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portal.DTO;
using Portal.SERVICE.IService;
using Portal.UTILITY;

namespace Portal.API.Controllers.UserController
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet("GetUser")]
        public async Task<ServiceResult<IEnumerable<SignUpModelDTO>>> GetUser()
        {
            ServiceResult<IEnumerable<SignUpModelDTO>> serviceResult = new ServiceResult<IEnumerable<SignUpModelDTO>>();
            try
            {
                var userResult = await _userService.GetUser();
                serviceResult.SetSuccess(userResult);
            }
            catch (Exception ex)
            {
                serviceResult.Failure(ex.Message);
            }
            return serviceResult;
        }

        [HttpGet("GetUser/{id}")]
        public async Task<ServiceResult<SignUpModelDTO>> GetUserById([FromRoute] int id)
        {
            ServiceResult<SignUpModelDTO> serviceResult = new ServiceResult<SignUpModelDTO>();
            try
            {
                var userResult = await _userService.GetUserById(id);
                serviceResult.SetSuccess(userResult);
            }
            catch (Exception ex)
            {
                serviceResult.Failure(ex.Message);
            }
            return serviceResult;
        }

        [HttpPost("CreateUser")]
        public async Task<ServiceResult<SignUpModelDTO>> CreateUser([FromBody] SignUpModelDTO Model)
        {
            ServiceResult<SignUpModelDTO> serviceResult = new ServiceResult<SignUpModelDTO>();
            try
            {
                if (!ModelState.IsValid)
                {
                    serviceResult.Failure("Model State is Not Valid");
                }
                else
                {
                    var userResult = await _userService.AddUser(Model);
                    if (userResult > 0)
                        serviceResult.Success("");
                    else
                        serviceResult.Failure("");
                }
            }
            catch (Exception ex)
            {
                serviceResult.Failure(ex.Message);
            }
            return serviceResult;
        }

        [HttpPut("EditUser/{id}")]
        public async Task<ServiceResult<SignUpModelDTO>> EditUser([FromRoute] int id, [FromBody] SignUpModelDTO Model)
        {
            ServiceResult<SignUpModelDTO> serviceResult = new ServiceResult<SignUpModelDTO>();
            try
            {
                if (!ModelState.IsValid)
                {
                    serviceResult.Failure("Model State is Not Valid");
                }
                else
                {
                    var userResult = await _userService.UpdateUser(Model);
                    if (userResult > 0)
                        serviceResult.Success("");
                    else
                        serviceResult.Failure("");
                }
            }
            catch (Exception ex)
            {
                serviceResult.Failure(ex.Message);
            }
            return serviceResult;
        }

        [HttpDelete("DeleteUser/{id}")]
        public async Task<ServiceResult<SignUpModelDTO>> DeleteJob([FromRoute] int id, [FromBody] SignUpModelDTO Model)
        {
            ServiceResult<SignUpModelDTO> serviceResult = new ServiceResult<SignUpModelDTO>();
            try
            {
                if (!ModelState.IsValid)
                {
                    serviceResult.Failure("Model State is Not Valid");
                }
                else
                {
                    var userResult = await _userService.UpdateUser(Model);
                    if (userResult > 0)
                        serviceResult.Success("");
                    else
                        serviceResult.Failure("");
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
