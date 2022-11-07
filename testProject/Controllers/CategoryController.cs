using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace testProject.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager categorymanager = new CategoryManager(new EfCategoryDal());
        Context context = new Context();

        public IActionResult Index()
        {
            var values = categorymanager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCategory(Category p)
        {
            categorymanager.TInsert(p);
            return RedirectToAction("index");
        }
    }
}
