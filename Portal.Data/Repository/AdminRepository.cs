using Portal.DATA.IRepository;
using Portal.MODEL;

namespace Portal.DATA.Repository
{
    public class AdminRepository : Repository<AdminModel>, IAdminRepository
    {

        public AdminRepository(PortalContext dbContex) : base(dbContex)
        {
        }

        public async Task<int> AddModel(AdminModel Model)
        {
            var ModelResult =  await Add(Model);
            return ModelResult;
        }

        public async Task<int> DeleteModel(AdminModel Model)
        {
            var ModelResult =  await Delete(Model);
            return ModelResult;
        }

        public async Task<IEnumerable<AdminModel>> GetModel()
        {
            var ModelResult = await GetAll();
            return ModelResult;
        }

        public Task<AdminModel> GetModelById(int id)
        {
            var ModelResult = GetById(id);
            return ModelResult;
        }

        public Task<int> UpdateModel(AdminModel Model)
        {
            var ModelResult = Update(Model);
            return ModelResult;
        }
    }
}
