using Microsoft.IdentityModel.Tokens;
using Portal.DATA.IRepository;
using Portal.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Portal.DATA.Repository
{
    public class AuthenticationRepository : IAuthenticationRepository
    {

        public async Task GenerateToken(LoginModelDTO loginModelDTO)
        {
           //var symetricKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes())
        }
    }
}
