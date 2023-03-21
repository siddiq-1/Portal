using Portal.DATA.IRepository;
using Portal.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.DATA.Repository
{
    public class RecruitersRepository : Repository<RecruitersModel> ,IRecruitersRepository
    {

        readonly Repository<RecruitersModel> _recruitersRepo;
        public RecruitersRepository(PortalContext db, Repository<RecruitersModel> recruitersRepo) : base(db)
        {
            _recruitersRepo = recruitersRepo;
        }

        public Task<int> AddModel(RecruitersModel Model)
        {
            return Add(Model);
        }

        public Task<int> DeleteModel(RecruitersModel Model)
        {
            return Delete(Model);
        }

        public Task<IEnumerable<RecruitersModel>> GetModel()
        {
            return _recruitersRepo.GetAll();
        }

        public Task<RecruitersModel> GetModelById(int id)
        {
            return _recruitersRepo.GetById(id);
        }

        public Task<int> UpdateModel(RecruitersModel Model)
        {
            return Update(Model);
        }
    }
}
