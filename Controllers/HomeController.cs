using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication8.Models;

namespace WebApplication8.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.Title = "Home";
            return View();
        }
        public IActionResult liveagentsupport()
        {
            ViewBag.Title = "liveagentsupport";
            return View();
        }

        public IActionResult WhatsAppBroadcasting()
        {
            ViewBag.Title = "Home";
            return View();
        }

        public IActionResult ReportsAnalytics()
        {
            ViewBag.Title = "Home";
            return View();
        }

        public IActionResult AutomatedChatBot()
        {
            return View();
        }

        public IActionResult ConversationalMarketing()
        {
            ViewBag.Title = "Home";
            return View();
        }

        public IActionResult AutoSegregation()
        {
            ViewBag.Title = "Home";
            return View();
        }

        public IActionResult AppMarketing()
        {
            ViewBag.Title = "Home";
            return View();
        }

        public IActionResult WhatsAppMarketing()
        {
            ViewBag.Title = "Home";
            return View();
        }

        public IActionResult WhatsappCommerce()
        {
            return View();
        }

        public IActionResult WhatsappSupport()
        {
            ViewBag.Title = "Home";
            return View();
        }

        public IActionResult WhatsappAuthentication()
        {
            ViewBag.Title = "Home";
            return View();
        }

        public IActionResult EcommerceRetail()
        {
            ViewBag.Title = "Home";
            return View();
        }

        public IActionResult Healthcare()
        {
            ViewBag.Title = "Home";
            return View();
        }

        public IActionResult EdTech()
        {
            ViewBag.Title = "Home";
            return View();
        }

        public IActionResult BankingBFSI()
        {
            ViewBag.Title = "Home";
            return View();
        }

        public IActionResult Mediaentertainment()
        {
            ViewBag.Title = "Home";
            return View();
        }

        public IActionResult FoodBeverage()
        {
            ViewBag.Title = "Home";
            return View();
        }

        public IActionResult TravelHospitality()
        {
            ViewBag.Title = "Home";
            return View();
        }

        public IActionResult AboutUs()
        {
            ViewBag.Title = "Home";
            return View();
        }

        public IActionResult WorkWithUs()
        {
            ViewBag.Title = "Home";
            return View();
        }

        public IActionResult PartnerWithUs()
        {
            ViewBag.Title = "Home";
            return View();
        }

        public IActionResult Blog()
        {
            ViewBag.Title = "Home";
            return View();
        }

        public IActionResult ContactUs()
        {
            ViewBag.Title = "Home";
            return View();
        }

        public IActionResult KnowledgeCenter()
        {
            ViewBag.Title = "Home";
            return View();
        }

        public IActionResult whatsappbusinessappvswhatsappbusinessapi()
        {
            ViewBag.Title = "Home";
            return View();
        }

        public IActionResult whatsappmarketingstrategiestodrivesales()
        {
            ViewBag.Title = "Home";
            return View();
        }

        public IActionResult reshapingcustomerengagementonwhatsapp()
        {
            ViewBag.Title = "Home";
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