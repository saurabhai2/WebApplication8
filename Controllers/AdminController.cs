using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using WebApplication8.Models;
using WebApplication8.Database;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebApplication8.Controllers
{
    public class AdminController : Controller 
    {
        private readonly AnantyaDbContext _context;

        public AdminController(AnantyaDbContext context)
        {
            _context = context;
        }

        public IActionResult Admin()
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            var number = rand.Next();
            HttpContext.Session.SetInt32("Token", @number);
            ViewBag.Number = HttpContext.Session.GetInt32("Token"); 
            return View();
        }
        public IActionResult Register(int r)
        {
            var number = HttpContext.Session.GetInt32("Token");
            if (r == @number)
            {
                return View();
            }
            else
            {
               
                return RedirectToAction("Admin");

            }
        }
        public IActionResult Dashboard(int r)
        {

            var number = HttpContext.Session.GetInt32("Token");
            ViewBag.Number = @number;
            if (r == @number)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Admin");
            }

        }
        public IActionResult Articles(int r)
        {

            var number = HttpContext.Session.GetInt32("Token");
            ViewBag.Number = @number;
            if (r == @number)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Admin");
            }

        }

        public IActionResult Tittle(int r)
        {

            var number = HttpContext.Session.GetInt32("Token");
            ViewBag.Number = @number;
            if (r == @number)
            {
                var data = _context.AdminTittle.FirstOrDefault(item => item.Id == 1);


                return View(data);
            }
            else
            {
                return RedirectToAction("Admin");
            }

        }

        public IActionResult Inbox(int r)
        {

            var number = HttpContext.Session.GetInt32("Token");
            if (r == @number)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Admin");
            }

        }

        public IActionResult FormData(int r)
        {

            var number = HttpContext.Session.GetInt32("Token");
            ViewBag.Number = @number;

            if (r == @number)
            {
                List<ContactForm> ContactForm = _context.ContactForm.ToList();
                return View(ContactForm);
            }
            else
            {
                return RedirectToAction("Admin");
            }

        }

        public IActionResult PatnerwithUs(int r)
        {

            var number = HttpContext.Session.GetInt32("Token");
            ViewBag.Number = @number;
            if (r == @number)
            {
                List<PatnerwithUs> PatnerwithUs = _context.PatnerwithUs.ToList();
                return View(PatnerwithUs);
            }
            else
            {
                return RedirectToAction("Admin");
            }

        }

        public IActionResult Logout(int r) 
        {

            var number = HttpContext.Session.GetInt32("Token");
            ViewBag.Number = @number;
            if (r == @number)
            {
                List<AdminTittle> AdminTittle = _context.AdminTittle.ToList();
                ViewBag.Data = AdminTittle.FirstOrDefault();
                List<Metatag> Metatag = _context.Metatag.ToList();
                ViewBag.DataMeta = Metatag.FirstOrDefault();
                List<MetatagCheck> MetatagCheck = _context.MetatagCheck.ToList();
                ViewBag.Checked = MetatagCheck.FirstOrDefault();
                return View();
            }
            else
            {
                return RedirectToAction("Admin");
            }
        }

        public IActionResult KnowlageCentre(int r)
        {

            var number = HttpContext.Session.GetInt32("Token");
            ViewBag.Number = @number;
            if (r == @number)
            {
                List<AdminTittle> AdminTittle = _context.AdminTittle.ToList();
                ViewBag.Data = AdminTittle.FirstOrDefault();
                List<Metatag> Metatag = _context.Metatag.ToList();
                ViewBag.DataMeta = Metatag.FirstOrDefault();
                List<MetatagCheck> MetatagCheck = _context.MetatagCheck.ToList();
                ViewBag.Checked = MetatagCheck.FirstOrDefault();
                return View();
            }
            else
            {
                return RedirectToAction("Admin");
            }
        }

        public IActionResult EditBlog(int r)
        {

            var number = HttpContext.Session.GetInt32("Token");
            ViewBag.Number = @number;
            if (r == @number)
            {
                List<BlogPost> BlogPost = _context.BlogPost.ToList();
                return View(BlogPost);
            }
            else
            {
                return RedirectToAction("Admin");
            }
        }

        public IActionResult Editblogs(int r , int Id)
        {

            var number = HttpContext.Session.GetInt32("Token");
            ViewBag.Number = @number;
            if (r == @number)
            {
                var existingRecord = _context.BlogPost.FirstOrDefault(item => item.Id == Id);
                return View(existingRecord);
            }
            else
            {
                return RedirectToAction("Admin");
            }
        }

        public IActionResult Logout1(int r)
        {            
                return RedirectToAction("Admin");
            
        }

        public IActionResult EmailVarification() 
        {
            return View();
        }

        

    } 
}
