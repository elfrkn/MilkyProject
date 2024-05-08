using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkProject.EntityLayer.Concrete
{
    public class Employer

    {
        public  int EmployerID { get; set; }
        public  string? ImageUrl { get; set; }
        public  string? NameSurname { get; set; }
        public  string? Job { get; set; }

        public  List<SocialMedia> SocialMedias { get; set; }

    }
}
