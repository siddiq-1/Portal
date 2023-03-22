using Portal.DTO;
using Portal.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.SERVICE.IService
{
    public interface IAdminService
    {
        Task<IEnumerable<AdminModelDTO>> GetAdmin();

        Task<AdminModelDTO> GetAdminById(int id);

        Task<int> AddAdmin(AdminModelDTO Model);
        Task<int> UpdateAdmin(AdminModelDTO Model);
        Task<int> DeleteAdmin(AdminModelDTO Model);

    }
}
