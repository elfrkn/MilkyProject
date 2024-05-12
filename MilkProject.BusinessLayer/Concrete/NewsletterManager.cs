using MilkProject.BusinessLayer.Abstract;
using MilkProject.EntityLayer.Concrete;
using MilkyProject.DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkProject.BusinessLayer.Concrete
{
    public class NewsletterManager : INewsletterService
    {
        private readonly INewsletterDal _newsletterDal;

        public NewsletterManager(INewsletterDal newsletterDal)
        {
            _newsletterDal = newsletterDal;
        }

        public void TDelete(int id)
        {
            _newsletterDal.Delete(id);
        }

        public Newsletter TGetById(int id)
        {
            return _newsletterDal.GetById(id);
        }

        public List<Newsletter> TGetListAll()
        {
            return _newsletterDal.GetListAll();
        }

        public int TGetNewsletterCount()
        {
            return _newsletterDal.GetNewsletterCount();
        }

        public void TInsert(Newsletter entity)
        {
            _newsletterDal.Insert(entity);
        }

        public void TUpdate(Newsletter entity)
        {
            _newsletterDal.Update(entity);
        }
    }
}
