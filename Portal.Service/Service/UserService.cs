using AutoMapper;
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
    public class UserService : IUserService
    {
        readonly UserRepository _userRepository;
        readonly IMapper _mapper;
        public UserService(UserRepository userRepository, IMapper mapper)
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

        public async Task<IEnumerable<SignUpModelDTO>> GetUser()
        {
            var userModel = await _userRepository.GetModel();
            var userResult = _mapper.Map<IEnumerable<UserModel>, IEnumerable<SignUpModelDTO>>(userModel);
            return userResult;
        }

        public async Task<SignUpModelDTO> GetUserById(int id)
        {
            var userModel =await _userRepository.GetById(id);
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
