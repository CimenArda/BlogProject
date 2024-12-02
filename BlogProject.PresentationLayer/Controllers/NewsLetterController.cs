using BlogProject.DataAccesLayer.Context;
using Microsoft.AspNetCore.Mvc;
using SensiveBlogProject.BusinessLayer.Abstract;
using SensiveBlogProject.EntityLayer.Concrete;

namespace BlogProject.PresentationLayer.Controllers
{
    public class NewsLetterController : Controller
    {
     private readonly INewsLetterService _newsletterService;

        public NewsLetterController(INewsLetterService newsletterService)
        {
            _newsletterService = newsletterService;
        }

        [HttpPost]
        public IActionResult Subscribe(NewsLetter newsLetter)
        {
            _newsletterService.TInsert(newsLetter);
            return RedirectToAction("Index", "Default");
        }
    }
}
