using Microsoft.AspNetCore.Mvc;
using WebApplication8.Database;
using WebApplication8.Models;

namespace WebApplication8.Controllers
{
    public class PostController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly AnantyaDbContext _context;

        public PostController(IWebHostEnvironment webHostEnvironment, AnantyaDbContext context)
        {
            _webHostEnvironment = webHostEnvironment;
            _context = context;

        }
        [Route("blogs/{SlugUrl}")]
        public IActionResult blogs(string SlugUrl)
        {
            var BlogPost = _context.BlogPost.FirstOrDefault(item => item.SlugUrl == SlugUrl);
            if (BlogPost != null)
            {
                ViewBag.currentUrl = "https://anantya.ai" + HttpContext.Request.Path;
                return View(BlogPost);
            }
            return RedirectToAction("NotFound","Home");
        }

        
        [Route("KnowlageCentre/{Url}")]
        public IActionResult KnowlageCentre(string Url)
        {
            var replacedString = Url.Replace("-", " ");
            ViewBag.UrlData = _context.KnowlageCentre.Where(item => item.Category == replacedString).ToList();
            if (ViewBag.UrlData != null)
            {
                ViewBag.currentUrl = "https://anantya.ai" + HttpContext.Request.Path;
                return View();
            }
            return RedirectToAction("NotFound", "Home");
        }

        [Route("KnowlageCentres/{UrlCentre}")]
        public IActionResult KnowlageCentres(string UrlCentre)
        {
            var KnowlageCentre = _context.KnowlageCentre.FirstOrDefault(item => item.SlugUrl == UrlCentre);
            if(KnowlageCentre != null)
            {
                ViewBag.HeadData = _context.KnowlageCentre.Where(item => item.Category == KnowlageCentre.Category).ToList();

            }
            if (KnowlageCentre != null)
            {
                ViewBag.currentUrl = "https://anantya.ai" + HttpContext.Request.Path;
                return View(KnowlageCentre);
            }
            return RedirectToAction("NotFound", "Home");
        }
    }
}
