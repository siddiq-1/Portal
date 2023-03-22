using Portal.DTO;
using Portal.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.DATA.IRepository
{
    public interface IAuthenticationRepository
    {
        Task<UserModel> ValidateUser(LoginModelDTO loginModelDto);
        string GenerateToken(SignUpModelDTO signUpModelDTO);
    }
}
