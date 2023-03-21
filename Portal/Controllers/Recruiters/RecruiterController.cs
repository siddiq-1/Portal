using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portal.DTO;
using Portal.SERVICE.IService;
using Portal.UTILITY;

namespace Portal.API.Controllers.Recruiters
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecruiterController : ControllerBase
    {
        readonly IRecruiterService _recruiterService;
        public RecruiterController(IRecruiterService recruiterService)
        {
            _recruiterService = recruiterService;
        }
        [HttpGet("GetRecruiter")]
        public async Task<ServiceResult<IEnumerable<RecruitersModelDTO>>> GetRecruiter()
        {
            ServiceResult<IEnumerable<RecruitersModelDTO>> serviceResult = new ServiceResult<IEnumerable<RecruitersModelDTO>>();
            try
            {
                var recruiterResult = await _recruiterService.GetRecruiters();
                serviceResult.SetSuccess(recruiterResult);
            }
            catch (Exception ex)
            {
                serviceResult.Failure(ex.Message);
            }
            return serviceResult;
        }

        [HttpGet("GetRecruiter/{id}")]
        public async Task<ServiceResult<RecruitersModelDTO>> GetRecruiterById([FromRoute] int id)
        {
            ServiceResult<RecruitersModelDTO> serviceResult = new ServiceResult<RecruitersModelDTO>();
            try
            {
                var recruiterResult = await _recruiterService.GetRecruitersById(id);
                serviceResult.SetSuccess(recruiterResult);
            }
            catch (Exception ex)
            {
                serviceResult.Failure(ex.Message);
            }
            return serviceResult;
        }

        [HttpPost("CreateRecruiter")]
        public async Task<ServiceResult<RecruitersModelDTO>> CreateRecruiter([FromBody] RecruitersModelDTO Model)
        {
            ServiceResult<RecruitersModelDTO> serviceResult = new ServiceResult<RecruitersModelDTO>();
            try
            {
                if (!ModelState.IsValid)
                {
                    serviceResult.Failure("Model State is Not Valid");
                }
                else
                {
                    var recruiterResult = await _recruiterService.AddRecruiters(Model);
                    if (recruiterResult > 0)
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

        [HttpPut("EditRecruiter/{id}")]
        public async Task<ServiceResult<RecruitersModelDTO>> EditAdmin([FromRoute] int id, [FromBody] RecruitersModelDTO Model)
        {
            ServiceResult<RecruitersModelDTO> serviceResult = new ServiceResult<RecruitersModelDTO>();
            try
            {
                if (!ModelState.IsValid)
                {
                    serviceResult.Failure("Model State is Not Valid");
                }
                else
                {
                    var recruiterResult = await _recruiterService.UpdateRecruiters(Model);
                    if (recruiterResult > 0)
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

        [HttpDelete("DeleteRecruiter/{id}")]
        public async Task<ServiceResult<RecruitersModelDTO>> DeleteAdmin([FromRoute] int id, [FromBody] RecruitersModelDTO Model)
        {
            ServiceResult<RecruitersModelDTO> serviceResult = new ServiceResult<RecruitersModelDTO>();
            try
            {
                if (!ModelState.IsValid)
                {
                    serviceResult.Failure("Model State is Not Valid");
                }
                else
                {
                    var recruiterResult = await _recruiterService.DeleteRecruiters(Model);
                    if (recruiterResult > 0)
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
