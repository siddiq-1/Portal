using Portal.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.DATA.IRepository
{
    public interface IRecruitersRepository
    {
        Task<IEnumerable<RecruitersModel>> GetModel();

        Task<RecruitersModel> GetModelById(int id);

        Task<int> AddModel(RecruitersModel Model);
        Task<int> UpdateModel(RecruitersModel Model);
        Task<int> DeleteModel(RecruitersModel Model);
    }
}
