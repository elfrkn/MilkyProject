﻿using MilkProject.EntityLayer.Concrete;
using MilkyProject.DataAccessLayer.Abstract;
using MilkyProject.DataAccessLayer.Context;
using MilkyProject.DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyProject.DataAccessLayer.EntityFramework
{
    public class EfContactDal : GenericRepository<Contact>, IContactDal
    {
        public EfContactDal(MilkyContext context) : base(context)
        {
        }

        public int GetContactCount()
        {
            var context = new MilkyContext();
            return  context.Contacts.Count();
          
        }
    }
}
