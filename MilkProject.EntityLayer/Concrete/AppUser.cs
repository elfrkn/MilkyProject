﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyProject.EntityLayer.Concrete
{
    public class AppUser :IdentityUser<int>
    {
        public  string Name { get; set; }
        public  string Surname { get; set; }
    }
}
