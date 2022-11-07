using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class OrderManager : IOrderService
    {
        IOrdersDal _ordersDal;

        public OrderManager(IOrdersDal ordersDal)
        {
            _ordersDal = ordersDal;
        }

        public List<Orders> GetOrderListWithProduct()
        {
            throw new NotImplementedException();
        }

        public void TDelete(Orders t)
        {
            _ordersDal.Delete(t);
        }

        public Orders TGetById(int id)
        {
            return _ordersDal.GetById(id);
        }

        public List<Orders> TGetList()
        {
            return _ordersDal.GetList();
        }

        public void TInsert(Orders t)
        {
            _ordersDal.Insert(t);
        }

        public void TUpdate(Orders t)
        {
            _ordersDal.Update(t);
        }
    }
}
