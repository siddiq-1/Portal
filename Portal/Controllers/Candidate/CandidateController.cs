﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portal.DTO;
using Portal.SERVICE.IService;
using Portal.UTILITY;

namespace Portal.API.Controllers.Candidate
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidateController : ControllerBase
    {
        readonly ICandidateService _candidateService;
        public CandidateController(ICandidateService candidateService)
        {
            _candidateService = candidateService;
        }
        [HttpGet("GetCandidate")]
        public async Task<ServiceResult<IEnumerable<CandidateModelDTO>>> GetCandidate()
        {
            ServiceResult<IEnumerable<CandidateModelDTO>> serviceResult = new ServiceResult<IEnumerable<CandidateModelDTO>>();
            try
            {
                var candidateResult = await _candidateService.GetCandidate();
                serviceResult.SetSuccess(candidateResult);
            }
            catch (Exception ex)
            {
                serviceResult.Failure(ex.Message);
            }
            return serviceResult;
        }

        [HttpGet("GetCandidate/{id}")]
        public async Task<ServiceResult<CandidateModelDTO>> GetCandidateById([FromRoute] int id)
        {
            ServiceResult<CandidateModelDTO> serviceResult = new ServiceResult<CandidateModelDTO>();
            try
            {
                var candidateResult = await _candidateService.GetCandidateById(id);
                serviceResult.SetSuccess(candidateResult);
            }
            catch (Exception ex)
            {
                serviceResult.Failure(ex.Message);
            }
            return serviceResult;
        }

        [HttpPost("CreateCandidate")]
        public async Task<ServiceResult<CandidateModelDTO>> CreateCandidate([FromBody] CandidateModelDTO Model)
        {
            ServiceResult<CandidateModelDTO> serviceResult = new ServiceResult<CandidateModelDTO>();
            try
            {
                if (!ModelState.IsValid)
                {
                    serviceResult.Failure("Model State is Not Valid");
                }
                else
                {
                    var adminResult = await _candidateService.AddCandidate(Model);
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

        [HttpPut("EditCandidate/{id}")]
        public async Task<ServiceResult<CandidateModelDTO>> EditCandidate([FromRoute] int id, [FromBody] CandidateModelDTO Model)
        {
            ServiceResult<CandidateModelDTO> serviceResult = new ServiceResult<CandidateModelDTO>();
            try
            {
                if (!ModelState.IsValid)
                {
                    serviceResult.Failure("Model State is Not Valid");
                }
                else
                {
                    var adminResult = await _candidateService.UpdateCandidate(Model);
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

        [HttpDelete("DeleteCandidate/{id}")]
        public async Task<ServiceResult<CandidateModelDTO>> DeleteCandidate([FromRoute] int id, [FromBody] CandidateModelDTO Model)
        {
            ServiceResult<CandidateModelDTO> serviceResult = new ServiceResult<CandidateModelDTO>();
            try
            {
                if (!ModelState.IsValid)
                {
                    serviceResult.Failure("Model State is Not Valid");
                }
                else
                {
                    var adminResult = await _candidateService.DeleteCandidate(Model);
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
