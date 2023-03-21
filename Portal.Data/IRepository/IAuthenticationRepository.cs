using Portal.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.DATA.IRepository
{
    public interface IAuthenticationRepository
    {
        Task GenerateToken(LoginModelDTO loginModelDTO);
    }
}
