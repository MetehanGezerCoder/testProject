using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace testProject.Controllers
{
    public class JobController1 : Controller
    {
        JobManager jobmanager = new JobManager(new EfJobDal());
        Context context = new Context();

        public IActionResult index()
        {
            var values = jobmanager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddJob()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddJob(Job p)
        {
            jobmanager.TInsert(p);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteJob(int id)
        {
            var value = jobmanager.TGetById(id);
            jobmanager.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateJob(int id)
        {
            var value = jobmanager.TGetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateJob(Job p)
        {
            //var value = productmanager.TGetById(p.ProductId);
            jobmanager.TUpdate(p);
            return RedirectToAction("Index");

        }
    }
}
