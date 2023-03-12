using System.ComponentModel;

namespace Portal.DTO
{
    public class CandidateModelDTO
    {
        public int candidateId { get; set; }
        public string FirstName { get; set; }
       public string MiddleName {get; set; } 
       public string LastName { get; set; }
       public int Age { get; set; }
       public string BioData { get; set; }
       public string Education { get; set; } 
       public string Skills { get; set; }
       public string Hobbies { get; set; }
       public string CurrentComapnyName { get; set; }
       public int ExperienceYrs { get; set; }
    }
}