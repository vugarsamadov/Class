using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PustokProject.CoreModels;
using PustokProject.Persistance;
using PustokProject.ViewModels;

namespace PustokProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BooksController : Controller
    {
        public BooksController(ApplicationDbContext context)
        {
            Context = context;
        }

        public ApplicationDbContext Context { get; }

        public async Task<IActionResult> Index()
        {
            var model = new VM_BooksIndex();
            model.Books = await Context.Books.ToListAsync();
            return View(model);
        }

        public async Task<IActionResult> CreateBook()
        {
            var brands= await Context.Brands.ToListAsync();
            ViewBag.Brands = new SelectList(brands,"Id","Name","SelectBrand");
            var model = new VM_CreateBook();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBook(VM_CreateBook model)
        {
            var book = new Book();
            book.Name = model.Name;
            book.Description = model.Description;
            book.Price = model.Price;
            
            return View(model);
        }

        public async Task<IActionResult> UpdateBook()
        {
            return View();
        }



        


    }
}
