using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkProject.EntityLayer.Concrete
{
    public class Adress
    {
        public  int AdressID { get; set; }
        public  string? Detail { get; set; }
        public  string? Phone { get; set; }
        public  string? Mail { get; set; }
        public  string? BusinessHoursMidWeek { get; set; }
        public string? BusinessHoursMidWeekand { get; set; }
    }
}
