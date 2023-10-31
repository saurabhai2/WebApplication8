using Microsoft.AspNetCore.Mvc;

namespace WebApplication8.Controllers
{
    public class LoginValidationController : Controller
    {
        public IActionResult login(string UserName, String Password)
        {

            if (UserName == "Saurabh" && Password == "Saurabh@123")
            {
                var number = HttpContext.Session.GetInt32("Token");
                return RedirectToAction("Dashboard", "Admin", new {r= number});
            }
            else
            {
                return RedirectToAction("Admin", "Admin");
            }
        }
    }
}
