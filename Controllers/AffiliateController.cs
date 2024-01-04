using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication8.Database;
using WebApplication8.Models;

namespace WebApplication8.Controllers
{
    public class AffiliateController : Controller
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly AnantyaDbContext _context;

        public AffiliateController(IWebHostEnvironment hostingEnvironment, AnantyaDbContext context)
        {
            _hostingEnvironment = hostingEnvironment;
            _context = context;
        }
        public IActionResult GenerateAffiliate(Affiliate Affiliate)
        {
            string Name = Affiliate.Name.Substring(0, Affiliate.Name.Length - 3);
            string Phone = Affiliate.phone.Substring(0, Affiliate.phone.Length - 3);
            TempData["Affiliate"] = "Ana" + Name + Phone;
            Affiliate.Affiliates = "Ana" + Name + Phone;
            if (Affiliate != null)
            {
                _context.Affiliate.Add(Affiliate);
                _context.SaveChanges();
            }
            return RedirectToAction("AffiliateProgram", "Home");
        }
    }
}
