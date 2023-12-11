using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PustokProject.CoreModels;
using PustokProject.Persistance;
using PustokProject.ViewModels.Tags;

namespace PustokProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TagsController : Controller
    {

        public TagsController(ApplicationDbContext context)
        {
            Context = context;
        }

        public ApplicationDbContext Context { get; }

        public async Task<IActionResult> Index()
        {
            var model = new VM_TagsIndex();
            model.Tags = await Context.Tags.ToListAsync();
            return View(model);
        }


        public async Task<IActionResult> CreateTag()
        {
            VM_TagsCreate model = new VM_TagsCreate();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTag(VM_TagsCreate model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var tag = new Tag();
            tag.Title = model.Title;
            await Context.Tags.AddAsync(tag);
            await Context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> UpdateTag(int id)
        {
            var tag = await Context.Tags.FirstOrDefaultAsync(t => t.Id == id);
            if (tag == null)
            {
                return BadRequest();
            }
            var model = new VM_TagsUpdate();
            model.Title = tag.Title;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateTag(int id, VM_TagsUpdate model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var tag = await Context.Tags.FirstOrDefaultAsync(t => t.Id == id);
            if (tag == null)
            {
                return BadRequest();
            }

            tag.Title = model.Title;

            await Context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> DeleteTag(int id)
        {
            var tag = await Context.Tags.FirstOrDefaultAsync(t => t.Id == id);
            if (tag == null)
            {
                return BadRequest();
            }
            Context.Tags.Remove(tag);
            await Context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


    }
}
