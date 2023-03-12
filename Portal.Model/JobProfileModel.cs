using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.MODEL
{
    public class JobProfileModel
    {
        [Key]
        public int Id { get; set;}

        public int RecuriterId {get;set;}

        public string Title {get;set;}

        public string Description {get;set;}

        public string ExperienceRequired {get;set;}

        public string JobField {get;set;}

        public string JobLocation {get;set;}

        public int Salary {get;set;}

        public bool IsActive {get;set;}
    }
}
