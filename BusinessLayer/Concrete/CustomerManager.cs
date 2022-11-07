using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
           _customerDal = customerDal;
        }

        public List<Customers> GetCustomersListWithJob()
        {
            return _customerDal.GetCustomerListWithJob();
        }

        public void TDelete(Customers t)
        {
            _customerDal.Delete(t);
        }

        public Customers TGetById(int id)
        {
            return _customerDal.GetById(id);
        }

        public List<Customers> TGetList()
        {
            return _customerDal.GetList();
        }

        public void TInsert(Customers t)
        {
            _customerDal.Insert(t);
        }

        public void TUpdate(Customers t)
        {
            _customerDal.Update(t);
        }
    }
}
