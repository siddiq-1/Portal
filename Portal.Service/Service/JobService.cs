using AutoMapper;
using Portal.DATA.IRepository;
using Portal.DATA.Repository;
using Portal.DTO;
using Portal.MODEL;
using Portal.SERVICE.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.SERVICE.Service
{
    public class JobService :IJobService
    {
       
        readonly IJobsRepository _jobRepository;
        readonly IMapper _mapper;
        public JobService(IJobsRepository jobRepository , IMapper mapper)
        {
            _mapper = mapper;
            _jobRepository = jobRepository;
        }
        public async Task<int> AddJob(JobProfileModelDTO Model)
        {
            var jobModel = _mapper.Map<JobProfileModelDTO, JobProfileModel>(Model);
            var jobResult = await _jobRepository.AddModel(jobModel);
            return jobResult;
        }

        public async Task<int> DeleteJob(JobProfileModelDTO Model)
        {
            var jobModel = _mapper.Map<JobProfileModelDTO, JobProfileModel>(Model);
            var jobResult = await _jobRepository.DeleteModel(jobModel);
            return jobResult;
        }

        public async Task<IEnumerable<JobProfileModelDTO>> GetJob()
        {
            var jobModel = await _jobRepository.GetModel();
            var jobResult = _mapper.Map<IEnumerable<JobProfileModel>, IEnumerable<JobProfileModelDTO>>(jobModel);
            return jobResult;
        }

        public async Task<JobProfileModelDTO> GetJobById(int id)
        {
            var jobModel = await _jobRepository.GetModelById(id);
            var jobResult = _mapper.Map<JobProfileModel, JobProfileModelDTO>(jobModel);
            return jobResult;
        }

        public async Task<int> UpdateJob(JobProfileModelDTO Model)
        {
            var jobModel = _mapper.Map<JobProfileModelDTO, JobProfileModel>(Model);
            var jobResult = await _jobRepository.UpdateModel(jobModel);
            return jobResult;
        }
    }
}
