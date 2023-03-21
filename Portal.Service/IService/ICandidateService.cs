using Portal.DTO;
using Portal.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.SERVICE.IService
{
    public interface ICandidateService
    {
        Task<IEnumerable<CandidateModelDTO>> GetCandidate();

        Task<CandidateModelDTO> GetCandidateById(int id);

        Task<int> AddCandidate(CandidateModelDTO Model);
        Task<int> UpdateCandidate(CandidateModelDTO Model);
        Task<int> DeleteCandidate(CandidateModelDTO Model);
    }
}
