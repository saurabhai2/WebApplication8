using Microsoft.AspNetCore.Mvc;

namespace WebApplication8.Controllers
{
    public class SessionExpireController : Controller
    {
        public SessionExpireController()
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            var number = rand.Next();
            HttpContext.Session.SetInt32("Token", @number);
            HttpContext.Session.SetInt32("Timeout", 1);
            
        }
    }
}
