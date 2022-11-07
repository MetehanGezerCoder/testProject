using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using DataAccessLayer.Concrete;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace testProject.Controllers
{
    public class ProductController : Controller
    {
        ProductManager productmanager = new ProductManager(new EfProductDal());
        Context context = new Context();

        public IActionResult viewProducts()
        {
            var values = productmanager.GetProductsListWithCategory();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddProduct() 
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            List<SelectListItem> kategoriler = (from x in categoryManager.TGetList()
                                              select new SelectListItem
                                              {
                                                  Text = x.kategori_ad,
                                                  Value = x.kategori_id.ToString()
                                              }).ToList();
            ViewBag.v = kategoriler;
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product p) 
        {
            productmanager.TInsert(p);
            return RedirectToAction("viewProducts");
        }

        public IActionResult DeleteProduct(int id) 
        {
     
            var value = productmanager.TGetById(id);
            productmanager.TDelete(value);
            return RedirectToAction("viewProducts");
        }

        [HttpGet]
        public IActionResult UpdateProduct(int id) 
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            List<SelectListItem> kategoriler = (from x in categoryManager.TGetList()
                                                select new SelectListItem
                                                {
                                                    Text = x.kategori_ad,
                                                    Value = x.kategori_id.ToString()
                                                }).ToList();
            ViewBag.v = kategoriler;
            var value = productmanager.TGetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateProduct(Product p) 
        {
            //var value = productmanager.TGetById(p.ProductId);
            productmanager.TUpdate(p);
            return RedirectToAction("viewProducts");

        }
    }
}
