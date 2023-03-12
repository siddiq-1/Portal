using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.MODEL
{
    public class AdminModel
    {
        [Key]
       public int Id { get; set;}
      
       public string FirstName { get; set; }
      
       public string MiddleName {get; set;}
      
       public string LastName {get; set;}
      
       public string BioData {get; set;}
      
       public string Education {get; set;}
      
       public string CurrentCompanyName {get; set;}
       
       public int ExperienceYrs {get; set;}
    }
}
