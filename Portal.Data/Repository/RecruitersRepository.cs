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

        public RecruitersRepository(PortalContext db) : base(db)
        {
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
            return GetAll();
        }

        public Task<RecruitersModel> GetModelById(int id)
        {
            return GetById(id);
        }

        public Task<int> UpdateModel(RecruitersModel Model)
        {
            return Update(Model);
        }
    }
}
