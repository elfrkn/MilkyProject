﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkProject.EntityLayer.Concrete
{
    public class Service
    {
        public  int ServiceID { get; set; }
        public  string SmallImageUrl { get; set; }
        public  string ImageUrl { get; set; }
        public  string Title { get; set; }
        public  string Description  { get; set; }
    }
}
