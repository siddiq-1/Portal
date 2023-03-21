using Portal.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.DATA.IRepository
{
    public interface IJobsRepository
    {
        Task<IEnumerable<JobProfileModel>> GetModel();

        Task<JobProfileModel> GetModelById(int id);

        Task<int> AddModel(JobProfileModel Model);
        Task<int> UpdateModel(JobProfileModel Model);
        Task<int> DeleteModel(JobProfileModel Model);
    }
}
