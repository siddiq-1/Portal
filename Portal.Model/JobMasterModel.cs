using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.MODEL
{
    public class JobMasterModel
    {
        [Key]
        public int Id { get; set; }

        public int AdminId { get; set; }

        public int RecruiterId { get; set; }

        public int CandidateId { get; set; }

        public int JobId { get; set; }

        public bool IsActive { get; set; }

        public virtual AdminModel Admins { get; set; }
        public virtual RecruitersModel recruiters { get; set; }
        public virtual CandidateModel Candidates { get; set; }
        public virtual JobProfileModel JobProfiles { get; set; }
    }
}
