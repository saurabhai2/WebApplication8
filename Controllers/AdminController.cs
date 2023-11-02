using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using WebApplication8.Models;
using WebApplication8.Database;

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
                return View();
            }
            else
            {
                return RedirectToAction("Admin");
            }

        }

        public IActionResult Metadata(int r)
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
                return View();
            }
            else
            {
                return RedirectToAction("Admin");
            }

        }


    } 
}
