using Portal.DATA.IRepository;
using Portal.MODEL;
using System.Linq.Expressions;

namespace Portal.DATA.Repository
{
    public class UserRepository :Repository<UserModel> , IUserRepository
    {
        public UserRepository(PortalContext dbContext) : base(dbContext)
        {
        }
        public async Task<int> AddModel(UserModel Model)
        {
           var userResult = await  Add(Model);
           return userResult;
        }

        public async Task<int> DeleteModel(UserModel Model)
        {
            var userResult = await Delete(Model);
            return userResult;
        }

        public async Task<UserModel> FindUserByPredicate(Expression<Func<UserModel, bool>> predicate)
        {
            var userResult = await FindModel(predicate);
            return userResult;
        }

        public async Task<IEnumerable<UserModel>> GetModel()
        {
            var userResult = await GetAll();
            return userResult;
        }

        public async Task<UserModel> GetModelById(int id)
        {
            var userResult = await GetById(id);
            return userResult;
        }

        public async Task<int> UpdateModel(UserModel Model)
        {
            var userResult = await Update(Model);
            return userResult;
        }

    }
}
