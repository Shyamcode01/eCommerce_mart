using e_commerInventry.Models.DbConnect;
using e_commerInventry.Models.product_model;
using e_commerInventry.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace e_commerInventry.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SubCategoryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SubCategoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        // sub category 
        [HttpGet]
        public IActionResult Index()
        {
            var subcategory=_context.subCategories.Include(x=> x.Category).ToList();

            return View(subcategory);
        }

        [HttpGet]
        public IActionResult Create()
        {
            SubCategoryViewModel vm= new SubCategoryViewModel();
            ViewBag.category=new SelectList(_context.categories,"Id","Title");
            return View(vm);
        }
        [HttpPost]
        public IActionResult Create(SubCategoryViewModel vm)
        {
            SubCategory model=new SubCategory();
            if(ModelState.IsValid)
            {
                model.Title=vm.Title;
                model.CategoryId=vm.CategoryId;
                _context.subCategories.Add(model);
                _context.SaveChanges();
            return RedirectToAction("Index");
            }

            return View(vm);
        }

        // update subcategory 

        [HttpGet]
        public IActionResult Edit(int id)
        {
            SubCategoryViewModel vm= new SubCategoryViewModel();
            var subcategory=_context.subCategories.Where(x=>x.Id==id).FirstOrDefault();
            if (subcategory != null)
            {
               vm.Id=subcategory.Id;
                vm.Title=subcategory.Title;
                ViewBag.category = new SelectList(_context.categories, "Id", "Title", subcategory.CategoryId);
            }

            return View(vm);
        }

        [HttpPost]
        public IActionResult Edit(SubCategoryViewModel sub)
        {
            if (ModelState.IsValid)
            {
                var model = _context.subCategories.Where(x => x.Id == sub.Id).FirstOrDefault();
                if (model != null)
                {

                model.CategoryId=sub.CategoryId;
                model.Title=sub.Title;

                _context.subCategories.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
                }
            }

            return View(sub);
        }

        // delete subcategory section 

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var subcategory=_context.subCategories.Where(x=>x.Id== id).FirstOrDefault();
            if (subcategory != null)
            {
                _context.subCategories.Remove(subcategory);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
