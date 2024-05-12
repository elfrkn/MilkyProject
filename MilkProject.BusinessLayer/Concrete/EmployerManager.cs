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
    public class EmployerManager : IEmployerService
    {
        private readonly IEmployerDal _employerDal;

        public EmployerManager(IEmployerDal employerDal)
        {
            _employerDal = employerDal;
        }

        public void TDelete(int id)
        {
            _employerDal.Delete(id);
        }

        public Employer TGetById(int id)
        {
            return _employerDal.GetById(id);
        }

        public int TGetEmployerCount()
        {
            return _employerDal.GetEmployerCount();
        }

        public List<Employer> TGetListAll()
        {
            return _employerDal.GetListAll();
        }

        public void TInsert(Employer entity)
        {
            _employerDal.Insert(entity);
        }

        public void TUpdate(Employer entity)
        {
            _employerDal.Update(entity);
        }
    }
}
