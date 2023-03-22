using AutoMapper;
using Portal.DATA.IRepository;
using Portal.DATA.Repository;
using Portal.DTO;
using Portal.MODEL;
using Portal.SERVICE.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Portal.SERVICE.Service
{
    public class UserService : IUserService
    {
        readonly IUserRepository _userRepository;
        readonly IMapper _mapper;
        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public async Task<int> AddUser(SignUpModelDTO Model)
        {
            var userModel = _mapper.Map<SignUpModelDTO, UserModel>(Model);
            var userResult = await _userRepository.AddModel(userModel);
            return userResult;
        }

        public async Task<int> DeleteUser(SignUpModelDTO Model)
        {
            var userModel = _mapper.Map<SignUpModelDTO, UserModel>(Model);
            var userResult = await _userRepository.DeleteModel(userModel);  
            return userResult;
        }

        public async Task<SignUpModelDTO> FindUser(Expression<Func<SignUpModelDTO, bool>> predicate)
        {
            var userModel = _mapper.Map<Expression<Func<SignUpModelDTO,bool>>, Expression<Func<UserModel,bool>>>(predicate);
            var result = await _userRepository.FindUserByPredicate(userModel);
            var userResult = _mapper.Map<UserModel, SignUpModelDTO>(result);
            return userResult;
        }

        public async Task<IEnumerable<SignUpModelDTO>> GetUser()
        {
            var userModel = await _userRepository.GetModel();
            var userResult = _mapper.Map<IEnumerable<UserModel>, IEnumerable<SignUpModelDTO>>(userModel);
            return userResult;
        }

        public async Task<SignUpModelDTO> GetUserById(int id)
        {
            var userModel =await _userRepository.GetModelById(id);
            var userResult = _mapper.Map<UserModel, SignUpModelDTO>(userModel);
            return userResult;
        }

        public async Task<int> UpdateUser(SignUpModelDTO Model)
        {
            var userModel = _mapper.Map<SignUpModelDTO, UserModel>(Model);
            var userResult = await _userRepository.UpdateModel(userModel);
            return userResult;
        }
    }
}
