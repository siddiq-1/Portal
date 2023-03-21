using Portal.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.DATA.IRepository
{
    public interface ICandidateRepository 
    {
        Task<IEnumerable<CandidateModel>> GetModel();

        Task<CandidateModel> GetModelById(int id);

        Task<int> AddModel(CandidateModel Model);
        Task<int> UpdateModel(CandidateModel Model);
        Task<int> DeleteModel(CandidateModel Model);
    }
}
