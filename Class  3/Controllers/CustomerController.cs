using Microsoft.AspNetCore.Mvc;

namespace Class__3.Controllers
{
    public class CustomerController : Controller
    {
        [Route("Customer/Index")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("Customer/Info")]

        public IActionResult Info()
        {
            return View();
        }
    }
}
