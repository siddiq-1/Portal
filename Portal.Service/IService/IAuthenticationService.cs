using Portal.DTO;
using Portal.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.SERVICE.IService
{
    public interface IAuthenticationService
    {
        Task<SignUpModelDTO> AuthenticateUser(LoginModelDTO loginModelDto);
        string GetToken(SignUpModelDTO signUpModelDTO);
    }
}
