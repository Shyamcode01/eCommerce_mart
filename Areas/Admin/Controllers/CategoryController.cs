using e_commerInventry.Models.DbConnect;
using e_commerInventry.Models.product_model;
using Microsoft.AspNetCore.Mvc;

namespace e_commerInventry.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {

        private readonly ApplicationDbContext _context;

        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }
        // index view section of category

        [HttpGet]
        public IActionResult Index()
        {

            var listofitem=_context.categories.ToList();
            return View(listofitem);
        }

        // create index form 
        [HttpGet]
        public IActionResult Create()
        {
            
            return View();
        }

        // form data send in database 
        [HttpPost]
        public IActionResult Create(Category category)
        {
            var result=_context.categories.Add(category);
            _context.SaveChanges();
            
            return RedirectToAction("Index");
        }


        // Edit section 

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var category = _context.categories.Where(x=>x.Id == id).FirstOrDefault();

            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(Category category) 
        {
            if (ModelState.IsValid)
            {
                var data = _context.categories.Where(x => x.Id == category.Id).FirstOrDefault();
                if(data != null)
                {
                   data.Title = category.Title;
                    _context.categories.Update(data);
                    _context.SaveChanges();
                    
                }

            }

            return RedirectToAction("Index");
        }

        //=================== delete section =================================

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var category=_context.categories.Where(x=>x.Id==id).FirstOrDefault();
            if (category != null)
            {
                _context.categories.Remove(category);
                _context.SaveChanges();
             
            }
            return RedirectToAction("Index");
        }
    }
}
