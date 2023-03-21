using AutoMapper;
using Portal.DTO;
using Portal.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.UTILITY
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<JobProfileModel, JobProfileModelDTO>().ReverseMap();
            CreateMap<CandidateModel, CandidateModelDTO>().ReverseMap();
            CreateMap<AdminModel, AdminModelDTO>().ReverseMap();
            CreateMap<RecruitersModel, RecruitersModelDTO>().ReverseMap();
            CreateMap<UserModel, SignUpModelDTO>().ReverseMap();
            CreateMap<UserModel, LoginModelDTO>().ReverseMap();
        }


    }
}
