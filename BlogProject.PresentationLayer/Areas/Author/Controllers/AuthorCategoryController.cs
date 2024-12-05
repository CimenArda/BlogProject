using Microsoft.AspNetCore.Mvc;

namespace BlogProject.PresentationLayer.Areas.Author.Controllers
{
    [Area("Author")]
    public class AuthorCategoryController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.v3 = "Kategori İşlemleri";
            return View();
        }
    }
}
