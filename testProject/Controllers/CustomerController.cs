using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace testProject.Controllers
{
    public class CustomerController : Controller
    {
        CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
        Context context = new Context();

        public IActionResult viewCustomer()
        {
            var values = customerManager.GetCustomersListWithJob();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddCustomer()
        {
            JobManager jobManager = new JobManager(new EfJobDal());
            List<SelectListItem> meslekler = (from x in jobManager.TGetList()
                                              select new SelectListItem
                                              {
                                                  Text = x.meslek_name,
                                                  Value = x.meslek_id.ToString()
                                              }).ToList();
            ViewBag.v = meslekler;
            ViewBag.date = DateTime.Today.ToShortDateString().ToString();
            return View();
        }

        [HttpPost]
        public IActionResult AddCustomer(Customers c)
        {
            customerManager.TInsert(c);
            return RedirectToAction("viewCustomer");
        }
    }
}
