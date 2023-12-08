using Microsoft.AspNetCore.Mvc;

namespace PustokProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogsController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }
    }
}
