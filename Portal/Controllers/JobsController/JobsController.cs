using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portal.DTO;
using Portal.SERVICE.IService;
using Portal.UTILITY;

namespace Portal.API.Controllers.JobsController
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobsController : ControllerBase
    {
        readonly IJobService _jobService;
        public JobsController(IJobService jobService)
        {
            _jobService = jobService;
        }
        [HttpGet("GetJobs")]
        public async Task<ServiceResult<IEnumerable<JobProfileModelDTO>>> GetJobs()
        {
            ServiceResult<IEnumerable<JobProfileModelDTO>> serviceResult = new ServiceResult<IEnumerable<JobProfileModelDTO>>();
            try
            {
                var jobResult = await _jobService.GetJob();
                serviceResult.SetSuccess(jobResult);
            }
            catch (Exception ex)
            {
                serviceResult.Failure(ex.Message);
            }
            return serviceResult;
        }

        [HttpGet("GetJob/{id}")]
        public async Task<ServiceResult<JobProfileModelDTO>> GetJobById([FromRoute] int id)
        {
            ServiceResult<JobProfileModelDTO> serviceResult = new ServiceResult<JobProfileModelDTO>();
            try
            {
                var jobResult = await _jobService.GetJobById(id);
                serviceResult.SetSuccess(jobResult);
            }
            catch (Exception ex)
            {
                serviceResult.Failure(ex.Message);
            }
            return serviceResult;
        }

        [HttpPost("CreateJob")]
        public async Task<ServiceResult<JobProfileModelDTO>> CreateJob([FromBody] JobProfileModelDTO Model)
        {
            ServiceResult<JobProfileModelDTO> serviceResult = new ServiceResult<JobProfileModelDTO>();
            try
            {
                if (!ModelState.IsValid)
                {
                    serviceResult.Failure("Model State is Not Valid");
                }
                else
                {
                    var jobResult = await _jobService.AddJob(Model);
                    if (jobResult > 0)
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

        [HttpPut("EditJob/{id}")]
        public async Task<ServiceResult<JobProfileModelDTO>> EditJob([FromRoute] int id, [FromBody] JobProfileModelDTO Model)
        {
            ServiceResult<JobProfileModelDTO> serviceResult = new ServiceResult<JobProfileModelDTO>();
            try
            {
                if (!ModelState.IsValid)
                {
                    serviceResult.Failure("Model State is Not Valid");
                }
                else
                {
                    var jobResult = await _jobService.UpdateJob(Model);
                    if (jobResult > 0)
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

        [HttpDelete("DeleteJob/{id}")]
        public async Task<ServiceResult<JobProfileModelDTO>> DeleteJob([FromRoute] int id, [FromBody] JobProfileModelDTO Model)
        {
            ServiceResult<JobProfileModelDTO> serviceResult = new ServiceResult<JobProfileModelDTO>();
            try
            {
                if (!ModelState.IsValid)
                {
                    serviceResult.Failure("Model State is Not Valid");
                }
                else
                {
                    var jobResult = await _jobService.UpdateJob(Model);
                    if (jobResult > 0)
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
