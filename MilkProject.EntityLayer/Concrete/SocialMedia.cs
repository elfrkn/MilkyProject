using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkProject.EntityLayer.Concrete
{
   public class SocialMedia
    {
        public  int SocialMediaID { get; set; }
        public  string? Name { get; set; }
        public  string? Url { get; set; }
        public  string? Icon { get; set; }
        public  int EmployerID { get; set; }
        public  Employer Employer { get; set; }
    }
}
