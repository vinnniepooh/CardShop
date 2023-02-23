using CardShop.DataAccess;
using Microsoft.AspNetCore.Mvc;
using CardShop.Models;

namespace CardShop.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Category> objCategoryList = _db.Categories.ToList();
            return View(objCategoryList);
        }

        public IActionResult Details()
        {
            
            return View();
        }
        public IActionResult Error()
        {
            return View();
        }

    }
}
