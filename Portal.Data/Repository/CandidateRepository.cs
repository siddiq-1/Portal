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
        readonly Repository<CandidateModel> _candidateRepo ;
        public CandidateRepository(PortalContext db ,Repository<CandidateModel> candidateRepo ) : base(db)
        {
            _candidateRepo = candidateRepo;
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
            return _candidateRepo.GetAll();
        }

        public Task<CandidateModel> GetModelById(int id)
        {
            return _candidateRepo.GetById(id);
        }

        public Task<int> UpdateModel(CandidateModel Model)
        {
            return Update(Model);
        }
    }
}
