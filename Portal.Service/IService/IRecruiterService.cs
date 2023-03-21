using Portal.DTO;
using Portal.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.SERVICE.IService
{
    public interface IRecruiterService
    {
        Task<IEnumerable<RecruitersModelDTO>> GetRecruiters();

        Task<RecruitersModelDTO> GetRecruitersById(int id);

        Task<int> AddRecruiters(RecruitersModelDTO Model);
        Task<int> UpdateRecruiters(RecruitersModelDTO Model);
        Task<int> DeleteRecruiters(RecruitersModelDTO Model);
    }
}
