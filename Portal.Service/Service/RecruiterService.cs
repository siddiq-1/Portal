using AutoMapper;
using Portal.DATA.IRepository;
using Portal.DATA.Repository;
using Portal.DTO;
using Portal.MODEL;
using Portal.SERVICE.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.SERVICE.Service
{
    public class RecruiterService : IRecruiterService
    {
        readonly IRecruitersRepository _recruitersRepository;
        readonly IMapper _mapper;
        public RecruiterService(IRecruitersRepository recruitersRepository,IMapper mapper)
        {
            _recruitersRepository = recruitersRepository;
            _mapper = mapper;
        }

        public async Task<int> AddRecruiters(RecruitersModelDTO Model)
        {
            var recruiterModel = _mapper.Map<RecruitersModelDTO, RecruitersModel>(Model);
           var recruiterResult = await _recruitersRepository.AddModel(recruiterModel);
            return recruiterResult;
        }

        public async Task<int> DeleteRecruiters(RecruitersModelDTO Model)
        {
            var recruiterModel = _mapper.Map<RecruitersModelDTO, RecruitersModel>(Model);
            var recruiterResult = await _recruitersRepository.DeleteModel(recruiterModel);
            return recruiterResult;
        }

        public async Task<IEnumerable<RecruitersModelDTO>> GetRecruiters()
        {
            var recruiterModel = await _recruitersRepository.GetModel();
            var recruiterResult = _mapper.Map<IEnumerable<RecruitersModel>, IEnumerable<RecruitersModelDTO>>(recruiterModel);
            return recruiterResult;
        }

        public async Task<RecruitersModelDTO> GetRecruitersById(int id)
        {
            var recruiterModel = await _recruitersRepository.GetModelById(id);
            var recruiterResult = _mapper.Map<RecruitersModel, RecruitersModelDTO>(recruiterModel);
            return recruiterResult;
        }

        public async Task<int> UpdateRecruiters(RecruitersModelDTO Model)
        {
            var recruiterModel = _mapper.Map<RecruitersModelDTO, RecruitersModel>(Model);
            var recruiterResult = await _recruitersRepository.UpdateModel(recruiterModel);
            return recruiterResult;
        }
    }
}
