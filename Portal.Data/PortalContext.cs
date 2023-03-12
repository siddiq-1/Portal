using Microsoft.EntityFrameworkCore;
using Portal.MODEL;

namespace Portal.DATA
{
    public class PortalContext: DbContext
    {
        public PortalContext(DbContextOptions<PortalContext> options):base(options)
        {

        }

        DbSet<AdminModel> Admins { get; set; }
        DbSet<CandidateModel> Candidates { get; set; }
        DbSet<JobMasterModel> JobMasters { get; set; }
        DbSet<JobProfileModel> JobProfiles { get; set; }
        DbSet<RecruitersModel> recruiters { get; set; }
    }
}
