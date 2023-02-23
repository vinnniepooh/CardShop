using Microsoft.AspNetCore.Mvc;

namespace CardShop.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
