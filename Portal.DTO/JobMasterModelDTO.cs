using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.DTO
{
    public class JobMasterModelDTO
    {
        public int Id { get; set; }

        public int AdminId { get; set; }

        public int RecruiterId { get; set; }

        public int CandidateId { get; set; }

        public int JobId { get; set; }

        public bool IsActive { get; set; }
    }
}
