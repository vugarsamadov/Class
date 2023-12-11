using Microsoft.AspNetCore.Mvc;

namespace PustokProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogsController : Controller
    {

        public async Task<IActionResult> Index()
        {
            await Task.Delay(100);
            return BadRequest();
        }
        
    }
}
