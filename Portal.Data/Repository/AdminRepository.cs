using Portal.DATA.IRepository;
using Portal.MODEL;

namespace Portal.DATA.Repository
{
    public class AdminRepository : Repository<AdminModel>, IAdminRepository
    {
        readonly Repository<AdminModel> _repository;

        public AdminRepository(PortalContext dbContex, Repository<AdminModel> repository) : base(dbContex)
        {
            _repository = repository;
        }

        public async Task<int> AddModel(AdminModel Model)
        {
            var ModelResult =  await _repository.Add(Model);
            return ModelResult;
        }

        public async Task<int> DeleteModel(AdminModel Model)
        {
            var ModelResult =  await _repository.Delete(Model);
            return ModelResult;
        }

        public async Task<IEnumerable<AdminModel>> GetModel()
        {
            var ModelResult = await _repository.GetAll();
            return ModelResult;
        }

        public Task<AdminModel> GetModelById(int id)
        {
            var ModelResult = _repository.GetById(id);
            return ModelResult;
        }

        public Task<int> UpdateModel(AdminModel Model)
        {
            var ModelResult = _repository.Update(Model);
            return ModelResult;
        }
    }
}
