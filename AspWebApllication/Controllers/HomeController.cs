using Microsoft.AspNetCore.Mvc;

namespace AspWebApllication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Courses()
        {
            return View();
        }
        public IActionResult Teacher()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Pricing() 
        {
            return View();
        }
        public IActionResult Contact() 
        {
            return View();
        }
    }
}
