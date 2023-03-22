using Portal.DATA.IRepository;
using Portal.MODEL;

namespace Portal.DATA.Repository
{
    public class JobRepository : Repository<JobProfileModel>, IJobsRepository
    {
        public JobRepository(PortalContext dbContext) : base(dbContext)
        {
        }
        public async Task<int> AddModel(JobProfileModel Model)
        {
           var ModelResult = await Add(Model);
            return ModelResult;
        }

        public async Task<int> DeleteModel(JobProfileModel Model)
        {
            var ModelResult = await Delete(Model);
            return ModelResult;
        }

        public async Task<IEnumerable<JobProfileModel>> GetModel()
        {
            var ModelResult = await GetAll();
            return ModelResult;
        }

        public async Task<JobProfileModel> GetModelById(int id)
        {
            var ModelResult = await GetById(id);
            return ModelResult; 
        }

        public async Task<int> UpdateModel(JobProfileModel Model)
        {
            var ModelResult = await Update(Model);
            return ModelResult;
        }
    }
}
