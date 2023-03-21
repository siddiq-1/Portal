using Portal.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.DATA.IRepository
{
    public interface IUserRepository
    {
        Task<IEnumerable<UserModel>> GetModel();

        Task<UserModel> GetModelById(int id);

        Task<int> AddModel(UserModel Model);
        Task<int> UpdateModel(UserModel Model);
        Task<int> DeleteModel(UserModel Model);
    }
}
