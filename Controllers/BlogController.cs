using Microsoft.AspNetCore.Mvc;
using System.Web;
using WebApplication8.Database;
using WebApplication8.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace WebApplication8.Controllers
{
    public class BlogController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly AnantyaDbContext _context;

        public BlogController(IWebHostEnvironment webHostEnvironment, AnantyaDbContext context)
        {
            _webHostEnvironment = webHostEnvironment;
            _context = context;

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
            string filepath = "./wwwroot/image";
            string fileName = Path.GetFileName(blog.FeatureImage.FileName);
            string fullfilepath = Path.GetFullPath(filepath);
            string fullPath = Path.Combine(fullfilepath, fileName);
            using (var fileStream = new FileStream(fullPath, FileMode.Create))
            {
                await blog.FeatureImage.CopyToAsync(fileStream);
            }
             blog.FeatureImagePath = "/image/"+ fileName;
            if (blog != null)
            {
                _context.BlogPost.Add(blog);
                _context.SaveChanges();
            }

            var number = HttpContext.Session.GetInt32("Token");
            return RedirectToAction("Articles", "Admin", new { r = number });
        }

        public async Task<IActionResult> EditblogPost(BlogPost blog)
        {
            var existingRecord = _context.BlogPost.FirstOrDefault(item => item.Id == blog.Id);
            
            if (existingRecord != null)
            {
                existingRecord.Title = blog.Title;
                existingRecord.Category = blog.Category;
                existingRecord.Meta = blog.Meta;
                existingRecord.Schema = blog.Schema;
                existingRecord.author = blog.author;
                existingRecord.MainHeading = blog.MainHeading;
                existingRecord.Content = blog.Content;
                existingRecord.SlugUrl = blog.SlugUrl;
                if(blog.FeatureImage != null)
                {
                    existingRecord.FeatureImagePath = "/image/" + Path.GetFileName(blog.FeatureImage.FileName);
                }

            }
            _context.SaveChanges();
            var number = HttpContext.Session.GetInt32("Token");
            return RedirectToAction("Articles", "Admin", new { r = number });
        }

        public async Task<IActionResult> PostKnowlage(KnowlageCentre blog)
        {
            
            if (blog != null)
            {
                _context.KnowlageCentre.Add(blog);
                _context.SaveChanges();
            }

            var number = HttpContext.Session.GetInt32("Token");
            return RedirectToAction("KnowlageCentre", "Admin", new { r = number });
        }

       

        [HttpPost]
        [Route("Admin/SaveTinyImage")]
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
            string ImagePath = "/image/" + fileName;
            var number = HttpContext.Session.GetInt32("Token");
            return Ok(new { ImagePath = @ImagePath });
        }

        public async Task<IActionResult> EditKnowlage(KnowlageCentre blog)
        {
            var existingRecord = _context.KnowlageCentre.FirstOrDefault(item => item.Id == blog.Id);
            
            if (existingRecord != null)
            {
                
                existingRecord.Title = blog.Title;
                existingRecord.CetegoryLine = blog.CetegoryLine;
                existingRecord.Category = blog.Category;
                existingRecord.Meta = blog.Meta;
                existingRecord.Schema = blog.Schema;
                existingRecord.author = blog.author;
                existingRecord.MainHeading = blog.MainHeading;
                existingRecord.Content = blog.Content;
                existingRecord.SlugUrl = blog.SlugUrl;


            }
            _context.SaveChanges();
            var number = HttpContext.Session.GetInt32("Token");
            return RedirectToAction("KnowlageCentre", "Admin", new { r = number });
        }

        public IActionResult Delete(int id)
        {
            var entityToDelete = _context.BlogPost.FirstOrDefault(e => e.Id == id);

            if (entityToDelete != null)
            {
                // Remove the entity
                _context.BlogPost.Remove(entityToDelete);

                // Save changes to delete the entity from the database
                _context.SaveChanges();
            }
            var number = HttpContext.Session.GetInt32("Token");
            return RedirectToAction("EditBlog", "Admin", new { r = number });
        }

        public IActionResult DeleteKnowlage(int id)
        {
            var entityToDelete = _context.KnowlageCentre.FirstOrDefault(e => e.Id == id);

            if (entityToDelete != null)
            {
                // Remove the entity
                _context.KnowlageCentre.Remove(entityToDelete);

                // Save changes to delete the entity from the database
                _context.SaveChanges();
            }
            var number = HttpContext.Session.GetInt32("Token");
            return RedirectToAction("EditKnowlage", "Admin", new { r = number });
        }

    }

    
}
