using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication8.Models;
using WebApplication8.Database;

namespace WebApplication8.Controllers
{

    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        private readonly AnantyaDbContext _context;

        
        public HomeController(ILogger<HomeController> logger, AnantyaDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
           var data = _context.AdminTittle.ToList();
            if (data.FirstOrDefault()?.Index != null)
            {
                ViewBag.Title = data.FirstOrDefault()?.Index;
            }

            return View();
        }
        public IActionResult liveagentsupport()
        {
            var data = _context.AdminTittle.ToList();
            if (data.FirstOrDefault()?.liveagentsupport != null)
            {
                ViewBag.Title = data.FirstOrDefault()?.liveagentsupport;
            }
           
            return View();
        }

        public IActionResult WhatsAppBroadcasting()
        {
            var data = _context.AdminTittle.ToList();
            if (data.FirstOrDefault()?.WhatsAppBroadcasting != null)
            {
                ViewBag.Title = data.FirstOrDefault()?.WhatsAppBroadcasting;
            }
            return View();
        }

        public IActionResult ReportsAnalytics()
        {
            var data = _context.AdminTittle.ToList();
            if (data.FirstOrDefault()?.ReportsAnalytics != null)
            {
                ViewBag.Title = data.FirstOrDefault()?.ReportsAnalytics;
            }
            return View();
        }

        public IActionResult AutomatedChatBot()
        {
            var data = _context.AdminTittle.ToList();
            if (data.FirstOrDefault()?.AutomatedChatBot != null)
            {
                ViewBag.Title = data.FirstOrDefault()?.AutomatedChatBot;
            }
            return View();
        }

        public IActionResult ConversationalMarketing()
        {
            var data = _context.AdminTittle.ToList();
            if (data.FirstOrDefault()?.ConversationalMarketing != null)
            {
                ViewBag.Title = data.FirstOrDefault()?.ConversationalMarketing;
            }
            return View();
        }

        public IActionResult AutoSegregation()
        {
            var data = _context.AdminTittle.ToList();
            if (data.FirstOrDefault()?.AutoSegregation != null)
            {
                ViewBag.Title = data.FirstOrDefault()?.AutoSegregation;
            }
            return View();
        }

        public IActionResult AppMarketing()
        {
            var data = _context.AdminTittle.ToList();
            if (data.FirstOrDefault()?.AppMarketing != null)
            {
                ViewBag.Title = data.FirstOrDefault()?.AppMarketing;
            }
            return View();
        }

        public IActionResult WhatsAppMarketing()
        {
            var data = _context.AdminTittle.ToList();
            if (data.FirstOrDefault()?.WhatsAppMarketing != null)
            {
                ViewBag.Title = data.FirstOrDefault()?.WhatsAppMarketing;
            }
            return View();
        }

        public IActionResult WhatsappCommerce()
        {
            var data = _context.AdminTittle.ToList();
            if (data.FirstOrDefault()?.WhatsappCommerce != null)
            {
                ViewBag.Title = data.FirstOrDefault()?.WhatsappCommerce;
            }
            return View();
        }

        public IActionResult WhatsappSupport()
        {
            var data = _context.AdminTittle.ToList();
            if (data.FirstOrDefault()?.WhatsappSupport != null)
            {
                ViewBag.Title = data.FirstOrDefault()?.WhatsappSupport;
            }
            return View();
        }

        public IActionResult WhatsappAuthentication()
        {
            var data = _context.AdminTittle.ToList();
            if (data.FirstOrDefault()?.WhatsappAuthentication != null)
            {
                ViewBag.Title = data.FirstOrDefault()?.WhatsappAuthentication;
            }
            return View();
        }

        public IActionResult EcommerceRetail()
        {
            var data = _context.AdminTittle.ToList();
            if (data.FirstOrDefault()?.EcommerceRetail != null)
            {
                ViewBag.Title = data.FirstOrDefault()?.EcommerceRetail;
            }
            return View();
        }

        public IActionResult Healthcare()
        {
            var data = _context.AdminTittle.ToList();
            if (data.FirstOrDefault()?.Healthcare != null)
            {
                ViewBag.Title = data.FirstOrDefault()?.Healthcare;
            }
            return View();
        }

        public IActionResult EdTech()
        {
            var data = _context.AdminTittle.ToList();
            if (data.FirstOrDefault()?.EdTech != null)
            {
                ViewBag.Title = data.FirstOrDefault()?.EdTech;
            }
            return View();
        }

        public IActionResult BankingBFSI()
        {
            var data = _context.AdminTittle.ToList();
            if (data.FirstOrDefault()?.BankingBFSI != null)
            {
                ViewBag.Title = data.FirstOrDefault()?.BankingBFSI;
            }
            return View();
        }

        public IActionResult Mediaentertainment()
        {
            var data = _context.AdminTittle.ToList();
            if (data.FirstOrDefault()?.Mediaentertainment != null)
            {
                ViewBag.Title = data.FirstOrDefault()?.Mediaentertainment;
            }
            return View();
        }

        public IActionResult FoodBeverage()
        {
            var data = _context.AdminTittle.ToList();
            if (data.FirstOrDefault()?.FoodBeverage != null)
            {
                ViewBag.Title = data.FirstOrDefault()?.FoodBeverage;
            }
            return View();
        }

        public IActionResult TravelHospitality()
        {
            var data = _context.AdminTittle.ToList();
            if (data.FirstOrDefault()?.TravelHospitality != null)
            {
                ViewBag.Title = data.FirstOrDefault()?.TravelHospitality;
            }
            return View();
        }

        public IActionResult AboutUs()
        {
            var data = _context.AdminTittle.ToList();
            if (data.FirstOrDefault()?.AboutUs != null)
            {
                ViewBag.Title = data.FirstOrDefault()?.AboutUs;
            }
            return View();
        }

        public IActionResult WorkWithUs()
        {
            var data = _context.AdminTittle.ToList();
            if (data.FirstOrDefault()?.WorkWithUs != null)
            {
                ViewBag.Title = data.FirstOrDefault()?.WorkWithUs;
            }
            return View();
        }

        public IActionResult PartnerWithUs()
        {
            var data = _context.AdminTittle.ToList();
            if (data.FirstOrDefault()?.PartnerWithUs != null)
            {
                ViewBag.Title = data.FirstOrDefault()?.PartnerWithUs;
            }
            return View();
        }

        public IActionResult Blog()
        {
            var data = _context.AdminTittle.ToList();
            if (data.FirstOrDefault()?.Blog != null)
            {
                ViewBag.Title = data.FirstOrDefault()?.Blog;
            }
            return View();
        }

        public IActionResult ContactUs()
        {
            var data = _context.AdminTittle.ToList();
            if (data.FirstOrDefault()?.ContactUs != null)
            {
                ViewBag.Title = data.FirstOrDefault()?.ContactUs;
            }
            return View();
        }

        public IActionResult KnowledgeCenter()
        {
            var data = _context.AdminTittle.ToList();
            if (data.FirstOrDefault()?.KnowledgeCenter != null)
            {
                ViewBag.Title = data.FirstOrDefault()?.KnowledgeCenter;
            }
            return View();
        }

        public IActionResult whatsappbusinessappvswhatsappbusinessapi()
        {
            var data = _context.AdminTittle.ToList();
            if (data.FirstOrDefault()?.whatsappbusinessappvswhatsappbusinessapi != null)
            {
                ViewBag.Title = data.FirstOrDefault()?.whatsappbusinessappvswhatsappbusinessapi;
            }
            return View();
        }

        public IActionResult whatsappmarketingstrategiestodrivesales()
        {
            var data = _context.AdminTittle.ToList();
            if (data.FirstOrDefault()?.whatsappmarketingstrategiestodrivesales != null)
            {
                ViewBag.Title = data.FirstOrDefault()?.whatsappmarketingstrategiestodrivesales;
            }
            return View();
        }

        public IActionResult reshapingcustomerengagementonwhatsapp()
        {
            var data = _context.AdminTittle.ToList();
            if (data.FirstOrDefault()?.reshapingcustomerengagementonwhatsapp != null)
            {
                ViewBag.Title = data.FirstOrDefault()?.reshapingcustomerengagementonwhatsapp;
            }
            return View();
        }



        [HttpPost]
        public string Contact(string Name, string email, string phone, string message, string url)
        {

            return Name;
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}