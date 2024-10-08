using Microsoft.AspNetCore.Mvc;

namespace SeniorDotNetProject.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}