using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using WebApplication8.Models;
using WebApplication8.Database;

namespace WebApplication8.Controllers
{
    public class AdminController : Controller
    {
       
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
