using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using EntityLayer.Concrete.SP;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using testProject.Models;

namespace testProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        Context context = new Context();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<_spSonSatilanUrunler> list;
            string sql = "EXEC sonSatilanBesUrun";
            list = context.sonSatilanBesUrun.FromSqlRaw<_spSonSatilanUrunler>(sql).ToList();
            return View(list);
        }

        public IActionResult Index2() 
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}