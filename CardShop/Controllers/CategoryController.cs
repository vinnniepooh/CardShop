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
            if (obj.Name == obj.DisplayOrder.ToString())
            {
                //Custom Error Message
                ModelState.AddModelError("name", "The Display Order cannot match excactly the name.");
            }
            if (ModelState.IsValid) 
            {
                _db.Categories.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Category created successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //GET
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var CategoryFromDb = _db.Categories.Find(id);

            //var CategoryFromDb = _db.Categories.FirstOrDefault(c => c.Id == id);

            if (CategoryFromDb == null)
            {
                return NotFound();
            }

            return View(CategoryFromDb);
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Category obj)
        {
            if (obj.Name == obj.DisplayOrder.ToString())
            {
                //Custom Error Message
                ModelState.AddModelError("name", "The Display Order cannot match excactly the name.");
            }
            if (ModelState.IsValid)
            {
                _db.Categories.Update(obj);
                _db.SaveChanges();
                TempData["update"] = "Category updated successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //GET
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var CategoryFromDb = _db.Categories.Find(id);

            //var CategoryFromDb = _db.Categories.FirstOrDefault(c => c.Id == id);

            if (CategoryFromDb == null)
            {
                return NotFound();
            }

            return View(CategoryFromDb);
        }
        //POST
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            var CategoryFromDb = _db.Categories.FirstOrDefault(x => x.Id == id);
            if (id == null)
            {
                return NotFound();
            }
            _db.Categories.Remove(CategoryFromDb);
            _db.SaveChanges();
            TempData["delete"] = "Category deleted successfully";
            return RedirectToAction("Index");

            return View(id);
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
