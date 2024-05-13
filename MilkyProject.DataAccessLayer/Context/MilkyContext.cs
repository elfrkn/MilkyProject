﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MilkProject.EntityLayer.Concrete;
using MilkyProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyProject.DataAccessLayer.Context
{
    public class MilkyContext :IdentityDbContext<AppUser,AppRole,int>

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=MSI;initial Catalog=MilkyDb;integrated Security=true");
        }

        public  DbSet<Category> Categories { get; set; }
        public  DbSet<Product> Products { get; set; }
        public  DbSet<Slider> Sliders { get; set; }
        public  DbSet<About> Abouts { get; set; }
        public  DbSet<Service> Services { get; set; }
        public  DbSet<Employer> Employers { get; set; }
        public  DbSet<Testimonial> Testimonials { get; set; }
        public  DbSet<SocialMedia> SocialMedias { get; set; }
        public  DbSet<Adress> Adresses { get; set; }
        public  DbSet<Newsletter> Newsletters { get; set; }
        public  DbSet<Contact> Contacts { get; set; }
        public  DbSet<Gallery> Galleries { get; set; }
    }
}
