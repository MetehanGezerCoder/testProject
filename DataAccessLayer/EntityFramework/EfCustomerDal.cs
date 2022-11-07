using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Respositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfCustomerDal : GenericRepository<Customers>, ICustomerDal
    {
        public List<Customers> GetCustomerListWithJob()
        {
            using (var c = new Context()) 
            {
                return c.musteriler.Include(x => x.Job).ToList(); 
            }
        }
    }
}
