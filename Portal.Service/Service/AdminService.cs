using AutoMapper;
using Portal.DATA.Repository;
using Portal.DTO;
using Portal.MODEL;
using Portal.SERVICE.IService;

namespace Portal.SERVICE.Service
{
    public class AdminService : IAdminService
    {
        readonly AdminRepository _adminRepository; 
        readonly IMapper _mapper;
        public AdminService(AdminRepository adminRepository , IMapper mapper)
        {
            _mapper = mapper;
            _adminRepository= adminRepository;
        }
        public async Task<int> AddAdmin(AdminModelDTO Model)
        {
            var adminModel = _mapper.Map<AdminModelDTO, AdminModel>(Model);
            var adminResult = await _adminRepository.AddModel(adminModel);
            return adminResult;
        }

        public async Task<int> DeleteAdmin(AdminModelDTO Model)
        {
            var adminModel = _mapper.Map<AdminModelDTO, AdminModel>(Model);
            var adminResult = await _adminRepository.DeleteModel(adminModel);
            return adminResult;
        }

        public async Task<IEnumerable<AdminModelDTO>> GetAdmin()
        {
            var adminModel = await _adminRepository.GetModel();
            var adminResult = _mapper.Map<IEnumerable<AdminModel>,IEnumerable<AdminModelDTO>>(adminModel);
            return adminResult;
        }

        public async Task<AdminModelDTO> GetAdminById(int id)
        {
            var adminModel = await _adminRepository.GetModelById(id);
            var adminResult = _mapper.Map<AdminModel,AdminModelDTO>(adminModel);
            return adminResult;
        }

        public async Task<int> UpdateAdmin(AdminModelDTO Model)
        {
            var adminModel = _mapper.Map<AdminModelDTO, AdminModel>(Model);
            var adminResult = await _adminRepository.UpdateModel(adminModel);
            return adminResult;
        }
    }
}