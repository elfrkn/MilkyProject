﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkProject.EntityLayer.Concrete
{
    public class Testimonial
    {
        public  int TestimonialID { get; set; }
        public  string Name { get; set; }
        public  string ImageUrl { get; set; }
        public  string Description { get; set; }    
    }
}
