using Portal.DTO;
using Portal.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.SERVICE.IService
{
    public interface IJobService
    {
        Task<IEnumerable<JobProfileModelDTO>> GetJob();

        Task<JobProfileModelDTO> GetJobById(int id);

        Task<int> AddJob(JobProfileModelDTO Model);
        Task<int> UpdateJob(JobProfileModelDTO Model);
        Task<int> DeleteJob(JobProfileModelDTO Model);
    }
}
