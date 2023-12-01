using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PustokProject.Persistance;
using PustokProject.ViewModels;

namespace PustokProject.Areas.Home.Controllers
{

    [Area("Admin")]
    public class HomeController : Controller
    {

        public ApplicationDbContext _context { get; }

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
            var vm = new VM_SlidersIndex();
            vm.PageTitle = "Admin index";
            var sliders = await _context.Sliders.ToListAsync();
            vm.Sliders = sliders;
            return View(vm);
        }

        [HttpGet]
        public async Task<IActionResult> UpdateSlider(int id)
        {
            var vm = new VM_UpdateSlider();
            var slider = await _context.Sliders.FindAsync(id);
            vm.Id = slider.Id;
            vm.Title = slider.Title;
            vm.Description = slider.Description;
            vm.ButtonText = slider.ButtonText;
            vm.TextPosition = slider.TextPosition;
            vm.ThumpnailUrl = slider.ThumpnailUrl;

            return View(vm);
        }
    }
}
