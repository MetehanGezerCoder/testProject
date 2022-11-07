using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace testProject.Controllers
{
    public class OrdersController : Controller
    {
        OrderManager _orderManager = new OrderManager(new EfOrderDal());
        Context context = new Context();

        public IActionResult viewOrders()
        {
            var values = _orderManager.TGetList();
            return View(values);
        }

        
    }
}
