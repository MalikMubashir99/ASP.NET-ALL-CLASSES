using Microsoft.AspNetCore.Mvc;

namespace Class__3.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [Route("Home/Index")]
        [Route("Home")]

        public IActionResult Index()
        {
            return View();
        }

        [Route("Home/Details")]
        public IActionResult Details()
        {
            return View();
        }
    }
}
