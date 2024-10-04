using e_commerInventry.Models.DbConnect;
using e_commerInventry.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace e_commerInventry.Areas.Admin.Controllers
{
    public class ItemController : Controller
    {
       private readonly ApplicationDbContext _context;

        public ItemController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {

            var item=_context.items.Include(x=>x.Category).Include(y=>y.SubCategory).ToList();
            return View(item);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ItemViewModel vm= new ItemViewModel();
            ViewBag.category=new SelectList(_context.categories,"Id","Title");
          
            return View();
        }

        [HttpGet]
        public IActionResult GetSubCategory(int categoryId)
        {
            var subcate=_context.subCategories.Where(x=>x.CategoryId==categoryId).FirstOrDefault();

            return Json(subcate);
        }
    }
}
