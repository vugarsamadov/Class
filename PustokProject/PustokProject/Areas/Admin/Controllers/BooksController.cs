using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.Operations;
using Microsoft.EntityFrameworkCore;
using PustokProject.CoreModels;
using PustokProject.Persistance;
using PustokProject.ViewModels.Books;

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
            model.Books = await Context.Books.Include(b => b.Brand)
                .Include(b=>b.Category)
                .ToListAsync();
            return View(model);
        }

        public async Task<IActionResult> CreateBook()
        {
            var brands= await Context.Brands.ToListAsync();
            var categories= await Context.Categories.Where(c =>c.ParentId != null).ToListAsync();
            ViewBag.Brands = new SelectList(brands,"Id","Name","SelectBrand");
            ViewBag.Categories = new SelectList(categories,"Id","Name","SelectCategory");
            
            var model = new VM_CreateBook();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBook(VM_CreateBook model)
        {
            var brands= await Context.Brands.ToListAsync();
            ViewBag.Brands = new SelectList(brands,"Id","Name","SelectBrand");
            var categories= await Context.Categories.Where(c =>c.ParentId != null).ToListAsync();
            ViewBag.Categories = new SelectList(categories,"Id","Name","SelectCategory");

            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var book = new Book();
            book.Name = model.Name;
            book.Description = model.Description;
            book.Price = model.Price;
            book.BrandId = model.BrandId;
            book.CategoryId = model.CategoryId;
            book.DiscountPercentage = model.DiscountPercentage;
            book.IsAvailable = model.IsAvailable == "true";
            book.ProductCode = model.ProductCode;
            book.CoverImageUrl = model.CoverImageUrl;

            var imageName = await model.ImageFile.SaveToRootWithUniqueNameAsync();
            book.CoverImageUrl = imageName;

            await Context.Books.AddAsync(book);
            await Context.SaveChangesAsync();


            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> UpdateBook(int id)
        {
            
            var brands= await Context.Brands.ToListAsync();
            ViewBag.Brands = new SelectList(brands,"Id","Name","SelectBrand");
            var categories= await Context.Categories.Where(c =>c.ParentId != null).ToListAsync();
            ViewBag.Categories = new SelectList(categories,"Id","Name","SelectCategory");
            
            var model = new VM_UpdateBook();

            var book = await Context.Books.FirstOrDefaultAsync(b => b.Id == id);
            
            if (book == null)
            {
                ModelState.AddModelError("Book","Book Not found!");
                return View(model);
            }

            model.Name = book.Name;
            model.Description = book.Description;
            model.Price = book.Price;
            model.BrandId = book.BrandId;
            model.CategoryId = book.CategoryId;
            model.DiscountPercentage = book.DiscountPercentage;
            model.IsAvailable = book.IsAvailable;
            model.ProductCode = book.ProductCode;

            model.CoverImageUrl = book.CoverImageUrl;
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateBook(int id,VM_UpdateBook model)
        {
            var brands= await Context.Brands.ToListAsync();
            ViewBag.Brands = new SelectList(brands,"Id","Name","SelectBrand");
            var categories= await Context.Categories.Where(c =>c.ParentId != null).ToListAsync();
            ViewBag.Categories = new SelectList(categories,"Id","Name","SelectCategory");

            

            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var book = await Context.Books.FirstOrDefaultAsync(b => b.Id == id);
            if (book == null)
            {
                ModelState.AddModelError("Book","Book Not found!");
                return View(model);
            }
                            book.Name = model.Name;
                            book.Description = model.Description;
                            book.Price = model.Price;
                            book.BrandId = model.BrandId;
                            book.CategoryId = model.CategoryId;
                            book.DiscountPercentage = model.DiscountPercentage;
                            book.IsAvailable = model.IsAvailable ?? false;
                            book.ProductCode = model.ProductCode;
            if (model.ImageFile != null)
            {
                var imageName = await model.ImageFile.SaveToRootWithUniqueNameAsync();
                
                BookImage bi = new();
                bi.BookId = id;
                bi.ImagePath = imageName;
                bi.Activate();
                await Context.BookImages.AddAsync(bi);

                await Context.SaveChangesAsync();
                book.CoverImageUrl = imageName;
            }
            await Context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        
        public async Task<IActionResult> DeleteBook(int id)
        {
            var book = await Context.Books.FirstOrDefaultAsync(b => b.Id == id);
            if (book != null)
            {
                book.Delete();
                await Context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> RevokeDelete(int id)
        {
            var book = await Context.Books.FindAsync(id);
            if (book != null)
            {
                book.RevokeDelete();
                await Context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
