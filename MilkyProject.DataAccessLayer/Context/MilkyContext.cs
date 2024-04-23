﻿using Microsoft.EntityFrameworkCore;
using MilkProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyProject.DataAccessLayer.Context
{
    public class MilkyContext :DbContext

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=MSI;initial Catalog=MilkyDb;integrated Security=true");
        }

        public  DbSet<Category> Categories { get; set; }
        public  DbSet<Product> Products { get; set; }
        public  DbSet<Slider> Sliders { get; set; }
    }
}