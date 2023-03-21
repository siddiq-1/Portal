using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Portal.DTO;
using Portal.MODEL;
using Portal.SERVICE.IService;
using Portal.UTILITY;

namespace Portal.API.Controllers.Admins
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        readonly IAdminService _adminService;
        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }
        [HttpGet("GetAdmin")]
        public async Task<ServiceResult<IEnumerable<AdminModelDTO>>> GetAdmin()
        {
            ServiceResult<IEnumerable<AdminModelDTO>> serviceResult = new ServiceResult<IEnumerable<AdminModelDTO>>();
            try
            {
                var adminResult = await _adminService.GetAdmin();
                serviceResult.SetSuccess(adminResult);
            }
            catch (Exception ex) 
            {
                serviceResult.Failure(ex.Message);
            }
            return serviceResult;
        }

        [HttpGet("GetAdmin/{id}")]
        public async Task<ServiceResult<AdminModelDTO>> GetAdminById([FromRoute] int id)
        {
            ServiceResult<AdminModelDTO> serviceResult = new ServiceResult<AdminModelDTO>();
            try
            {
                var adminResult = await _adminService.GetAdminById(id);
                serviceResult.SetSuccess(adminResult);
            }
            catch (Exception ex)
            {
                serviceResult.Failure(ex.Message);
            }
            return serviceResult;
        }

        [HttpPost("CreateAdmin")]
        public async Task<ServiceResult<AdminModelDTO>> CreateAdmin([FromBody] AdminModelDTO Model)
        {
            ServiceResult<AdminModelDTO> serviceResult = new ServiceResult<AdminModelDTO>();
            try
            {
                if (!ModelState.IsValid)
                {
                   serviceResult.Failure("Model State is Not Valid");
                }
                else
                {
                    var adminResult = await _adminService.AddAdmin(Model);
                    serviceResult.Success("");
                    if (adminResult > 0)
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

        [HttpPut("EditAdmin/{id}")]
        public async Task<ServiceResult<AdminModelDTO>> EditAdmin([FromRoute] int id ,[FromBody] AdminModelDTO Model)
        {
            ServiceResult<AdminModelDTO> serviceResult = new ServiceResult<AdminModelDTO>();
            try
            {
                if (!ModelState.IsValid)
                {
                    serviceResult.Failure("Model State is Not Valid");
                }
                else
                {
                    var adminResult = await _adminService.UpdateAdmin(Model);
                    serviceResult.Success("");
                }
            }
            catch (Exception ex)
            {
                serviceResult.Failure(ex.Message);
            }
            return serviceResult;
        }

        [HttpDelete("DeleteAdmin/{id}")]
        public async Task<ServiceResult<AdminModelDTO>> DeleteAdmin([FromRoute] int id , [FromBody] AdminModelDTO Model)
        {
            ServiceResult<AdminModelDTO> serviceResult = new ServiceResult<AdminModelDTO>();
            try
            {
                if (!ModelState.IsValid)
                {
                    serviceResult.Failure("Model State is Not Valid");
                }
                else
                {
                    var adminResult = await _adminService.DeleteAdmin(Model);
                    if (adminResult > 0)
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
