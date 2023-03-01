using BulkyBookLibrary.Data;
using BulkyBookLibrary.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyBookLibrary.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db= db;
        }
        public IActionResult Index()
        {
            IEnumerable<Category> objCategoryList =  _db.Categories.ToList();
            return View(objCategoryList);
        }
        
        //GET
        public IActionResult Create()
        {
            
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category obj)
        {
            if (ModelState.IsValid) { 
            _db.Categories.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
            }
            TempData["AlertMessage"] = "Enter the Required Data !";
            return View(obj);
        }
    }
}
