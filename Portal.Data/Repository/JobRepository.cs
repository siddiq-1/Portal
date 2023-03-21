using Portal.DATA.IRepository;
using Portal.MODEL;

namespace Portal.DATA.Repository
{
    public class JobRepository : Repository<JobProfileModel>, IJobsRepository
    {
        readonly Repository<JobProfileModel> _repository;
        public JobRepository(PortalContext dbContext, Repository<JobProfileModel> repository) : base(dbContext)
        {
            _repository = repository;
        }
        public async Task<int> AddModel(JobProfileModel Model)
        {
           var ModelResult = await _repository.Add(Model);
            return ModelResult;
        }

        public async Task<int> DeleteModel(JobProfileModel Model)
        {
            var ModelResult = await _repository.Delete(Model);
            return ModelResult;
        }

        public async Task<IEnumerable<JobProfileModel>> GetModel()
        {
            var ModelResult = await _repository.GetAll();
            return ModelResult;
        }

        public async Task<JobProfileModel> GetModelById(int id)
        {
            var ModelResult = await _repository.GetById(id);
            return ModelResult;
        }

        public async Task<int> UpdateModel(JobProfileModel Model)
        {
            var ModelResult = await _repository.Update(Model);
            return ModelResult;
        }
    }
}
