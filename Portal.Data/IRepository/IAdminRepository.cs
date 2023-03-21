using Portal.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.DATA.IRepository
{
    public interface IAdminRepository
    {
        Task<IEnumerable<AdminModel>> GetModel();

        Task<AdminModel> GetModelById(int id);

        Task<int> AddModel(AdminModel Model);
        Task<int> UpdateModel(AdminModel Model);
        Task<int> DeleteModel(AdminModel Model);
    }
}
