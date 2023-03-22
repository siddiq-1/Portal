using AutoMapper;
using Portal.DATA.IRepository;
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
    public class AuthenticationService : IAuthenticationService
    {
        readonly IAuthenticationRepository _authenticationRepository;
        readonly IMapper _mapper;
        public AuthenticationService(IAuthenticationRepository authenticationRepository ,IMapper mapper)
        {
            _authenticationRepository = authenticationRepository;
            _mapper = mapper;
        }

        public async Task<SignUpModelDTO> AuthenticateUser(LoginModelDTO loginModelDto)
        {
           var authResult = await _authenticationRepository.ValidateUser(loginModelDto);
            var isValidate = _mapper.Map<UserModel, SignUpModelDTO>(authResult);
            return isValidate;
        }

        public string GetToken(SignUpModelDTO signUpModelDTO)
        {
            var authResult =  _authenticationRepository.GenerateToken(signUpModelDTO);
            return authResult;
        }
    }
}
