using Microsoft.AspNetCore.Mvc;
using System.Web;
using WebApplication8.Models;


namespace WebApplication8.Controllers
{
    public class BlogController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public BlogController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        public async Task<IActionResult> SaveImageAsync(IFormFile file)
        {
            string filepath = "./wwwroot/image";
            string fileName = Path.GetFileName(file.FileName);
            string fullfilepath = Path.GetFullPath(filepath);
            string fullPath = Path.Combine(fullfilepath, fileName);
            using (var fileStream = new FileStream(fullPath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }
            var number = HttpContext.Session.GetInt32("Token");
            return RedirectToAction("Articles", "Admin", new {r = number });
        }

        public async Task<IActionResult> SaveImage1Async(IFormFile file)
        {
            string filepath = "./wwwroot";
            string fileName = Path.GetFileName(file.FileName);
            string fullfilepath = Path.GetFullPath(filepath);
            string fullPath = Path.Combine(fullfilepath, fileName);
            using (var fileStream = new FileStream(fullPath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }
            var number = HttpContext.Session.GetInt32("Token");
            return RedirectToAction("Dashboard", "Admin", new { r = number });
        }
        public async Task<IActionResult> PostBlog(BlogPost blog)
        {

            var number = HttpContext.Session.GetInt32("Token");
            return View(blog);
        }
    }
}
