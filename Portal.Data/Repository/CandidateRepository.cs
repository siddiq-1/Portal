using Portal.DATA.IRepository;
using Portal.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.DATA.Repository
{
    public class CandidateRepository : Repository<CandidateModel> , ICandidateRepository
    {
        public CandidateRepository(PortalContext db) : base(db)
        {
        }

        public Task<int> AddModel(CandidateModel Model)
        {
            return Add(Model);
        }

        public Task<int> DeleteModel(CandidateModel Model)
        {
            return Delete(Model);
        }

        public Task<IEnumerable<CandidateModel>> GetModel()
        {
            return GetAll();
        }

        public Task<CandidateModel> GetModelById(int id)
        {
            return GetById(id);
        }

        public Task<int> UpdateModel(CandidateModel Model)
        {
            return Update(Model);
        }
    }
}
