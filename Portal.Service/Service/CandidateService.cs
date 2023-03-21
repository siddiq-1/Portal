using AutoMapper;
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
    public class CandidateService :ICandidateService
    {
        readonly IMapper _mapper;
        readonly CandidateRepository _candidateRepository;
        public CandidateService(CandidateRepository candidateRepository,IMapper mapper)
        {
            _candidateRepository = candidateRepository;
            _mapper = mapper;
        }
        public async Task<int> AddCandidate(CandidateModelDTO Model)
        {
            var candidateModel = _mapper.Map<CandidateModelDTO, CandidateModel>(Model);
            var candidateResult = await _candidateRepository.AddModel(candidateModel);
            return candidateResult;
        }

        public async Task<int> DeleteCandidate(CandidateModelDTO Model)
        {
            var candidateModel = _mapper.Map<CandidateModelDTO, CandidateModel>(Model);
            var candidateResult = await _candidateRepository.DeleteModel(candidateModel);
            return candidateResult;
        }

        public async Task<IEnumerable<CandidateModelDTO>> GetCandidate()
        {
            
            var candidateModel = await _candidateRepository.GetModel();
            var candidateResult = _mapper.Map<IEnumerable<CandidateModel>, IEnumerable<CandidateModelDTO>>(candidateModel);
            return candidateResult;
        }

        public async Task<CandidateModelDTO> GetCandidateById(int id)
        {
            var candidateModel = await _candidateRepository.GetModelById(id);
            var candidateResult = _mapper.Map<CandidateModel, CandidateModelDTO>(candidateModel);
            return candidateResult;
        }

        public async Task<int> UpdateCandidate(CandidateModelDTO Model)
        {
            var candidateModel = _mapper.Map<CandidateModelDTO, CandidateModel>(Model);
            var candidateResult = await _candidateRepository.UpdateModel(candidateModel);
            return candidateResult;
        }
    }
}
