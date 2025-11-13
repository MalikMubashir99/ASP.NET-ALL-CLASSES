using Microsoft.AspNetCore.Mvc;

namespace Class__3.Controllers
{
    public class AdminController : Controller
    {
        //[Route("")]
        [Route("Admin/Index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
