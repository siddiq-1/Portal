using Portal.DATA.IRepository;
using Portal.MODEL;

namespace Portal.DATA.Repository
{
    public class UserRepository :Repository<UserModel> , IUserRepository
    {
        readonly Repository<UserModel> _userRepository;
        public UserRepository(PortalContext dbContext, Repository<UserModel> userRepository) : base(dbContext)
        {
            _userRepository = userRepository;
        }
        public async Task<int> AddModel(UserModel Model)
        {
           var userResult = await  _userRepository.Add(Model);
           return userResult;
        }

        public async Task<int> DeleteModel(UserModel Model)
        {
            var userResult = await _userRepository.Delete(Model);
            return userResult;
        }

        public async Task<IEnumerable<UserModel>> GetModel()
        {
            var userResult = await _userRepository.GetAll();
            return userResult;
        }

        public async Task<UserModel> GetModelById(int id)
        {
            var userResult = await _userRepository.GetById(id);
            return userResult;
        }

        public async Task<int> UpdateModel(UserModel Model)
        {
            var userResult = await _userRepository.Update(Model);
            return userResult;
        }
    }
}
