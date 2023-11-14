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
            var dataMeta = _context.Metatag.ToList();
            if (dataMeta.FirstOrDefault()?.IndexMeta != null)
            {
                ViewBag.Meta = dataMeta.FirstOrDefault()?.IndexMeta;
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
            var dataMeta = _context.Metatag.ToList();
            if (dataMeta.FirstOrDefault()?.liveagentsupportMeta != null)
            {
                ViewBag.Meta = dataMeta.FirstOrDefault()?.liveagentsupportMeta;
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
            var dataMeta = _context.Metatag.ToList();
            if (dataMeta.FirstOrDefault()?.liveagentsupportMeta != null)
            {
                ViewBag.Meta = dataMeta.FirstOrDefault()?.liveagentsupportMeta;
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
            var dataMeta = _context.Metatag.ToList();
            if (dataMeta.FirstOrDefault()?.ReportsAnalyticsMeta != null)
            {
                ViewBag.Meta = dataMeta.FirstOrDefault()?.ReportsAnalyticsMeta;
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
            var dataMeta = _context.Metatag.ToList();
            if (dataMeta.FirstOrDefault()?.ReportsAnalyticsMeta != null)
            {
                ViewBag.Meta = dataMeta.FirstOrDefault()?.ReportsAnalyticsMeta;
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
            var dataMeta = _context.Metatag.ToList();
            if (dataMeta.FirstOrDefault()?.ConversationalMarketingMeta != null)
            {
                ViewBag.Meta = dataMeta.FirstOrDefault()?.ConversationalMarketingMeta;
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
            var dataMeta = _context.Metatag.ToList();
            if (dataMeta.FirstOrDefault()?.AutoSegregationMeta != null)
            {
                ViewBag.Meta = dataMeta.FirstOrDefault()?.AutoSegregationMeta;
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
            var dataMeta = _context.Metatag.ToList();
            if (dataMeta.FirstOrDefault()?.AppMarketingMeta != null)
            {
                ViewBag.Meta = dataMeta.FirstOrDefault()?.AppMarketingMeta;
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
            var dataMeta = _context.Metatag.ToList();
            if (dataMeta.FirstOrDefault()?.WhatsAppMarketingMeta != null)
            {
                ViewBag.Meta = dataMeta.FirstOrDefault()?.WhatsAppMarketingMeta;
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
            var dataMeta = _context.Metatag.ToList();
            if (dataMeta.FirstOrDefault()?.WhatsappCommerceMeta != null)
            {
                ViewBag.Meta = dataMeta.FirstOrDefault()?.WhatsappCommerceMeta;
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
            var dataMeta = _context.Metatag.ToList();
            if (dataMeta.FirstOrDefault()?.WhatsappSupportMeta != null)
            {
                ViewBag.Meta = dataMeta.FirstOrDefault()?.WhatsappSupportMeta;
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
            var dataMeta = _context.Metatag.ToList();
            if (dataMeta.FirstOrDefault()?.WhatsappAuthenticationMeta != null)
            {
                ViewBag.Meta = dataMeta.FirstOrDefault()?.WhatsappAuthenticationMeta;
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
            var dataMeta = _context.Metatag.ToList();
            if (dataMeta.FirstOrDefault()?.EcommerceRetailMeta != null)
            {
                ViewBag.Meta = dataMeta.FirstOrDefault()?.EcommerceRetailMeta;
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
            var dataMeta = _context.Metatag.ToList();
            if (dataMeta.FirstOrDefault()?.HealthcareMeta != null)
            {
                ViewBag.Meta = dataMeta.FirstOrDefault()?.HealthcareMeta;
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
            var dataMeta = _context.Metatag.ToList();
            if (dataMeta.FirstOrDefault()?.EdTechMeta != null)
            {
                ViewBag.Meta = dataMeta.FirstOrDefault()?.EdTechMeta;
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
            var dataMeta = _context.Metatag.ToList();
            if (dataMeta.FirstOrDefault()?.BankingBFSIMeta != null)
            {
                ViewBag.Meta = dataMeta.FirstOrDefault()?.BankingBFSIMeta;
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
            var dataMeta = _context.Metatag.ToList();
            if (dataMeta.FirstOrDefault()?.MediaentertainmentMeta != null)
            {
                ViewBag.Meta = dataMeta.FirstOrDefault()?.MediaentertainmentMeta;
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
            var dataMeta = _context.Metatag.ToList();
            if (dataMeta.FirstOrDefault()?.FoodBeverageMeta != null)
            {
                ViewBag.Meta = dataMeta.FirstOrDefault()?.FoodBeverageMeta;
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
            var dataMeta = _context.Metatag.ToList();
            if (dataMeta.FirstOrDefault()?.TravelHospitalityMeta != null)
            {
                ViewBag.Meta = dataMeta.FirstOrDefault()?.TravelHospitalityMeta;
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
            var dataMeta = _context.Metatag.ToList();
            if (dataMeta.FirstOrDefault()?.AboutUsMeta != null)
            {
                ViewBag.Meta = dataMeta.FirstOrDefault()?.AboutUsMeta;
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
            var dataMeta = _context.Metatag.ToList();
            if (dataMeta.FirstOrDefault()?.WorkWithUsMeta != null)
            {
                ViewBag.Meta = dataMeta.FirstOrDefault()?.WorkWithUsMeta;
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
            var dataMeta = _context.Metatag.ToList();
            if (dataMeta.FirstOrDefault()?.PartnerWithUsMeta != null)
            {
                ViewBag.Meta = dataMeta.FirstOrDefault()?.PartnerWithUsMeta;
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
            var dataMeta = _context.Metatag.ToList();
            if (dataMeta.FirstOrDefault()?.BlogMeta != null)
            {
                ViewBag.Meta = dataMeta.FirstOrDefault()?.BlogMeta;
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
            var dataMeta = _context.Metatag.ToList();
            if (dataMeta.FirstOrDefault()?.ContactUsMeta != null)
            {
                ViewBag.Meta = dataMeta.FirstOrDefault()?.ContactUsMeta;
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
            var dataMeta = _context.Metatag.ToList();
            if (dataMeta.FirstOrDefault()?.KnowledgeCenterMeta != null)
            {
                ViewBag.Meta = dataMeta.FirstOrDefault()?.KnowledgeCenterMeta;
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
            var dataMeta = _context.Metatag.ToList();
            if (dataMeta.FirstOrDefault()?.ConversationalMarketingMeta != null)
            {
                ViewBag.Meta = dataMeta.FirstOrDefault()?.ConversationalMarketingMeta;
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
            var dataMeta = _context.Metatag.ToList();
            if (dataMeta.FirstOrDefault()?.ConversationalMarketingMeta != null)
            {
                ViewBag.Meta = dataMeta.FirstOrDefault()?.ConversationalMarketingMeta;
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
            var dataMeta = _context.Metatag.ToList();
            if (dataMeta.FirstOrDefault()?.ConversationalMarketingMeta != null)
            {
                ViewBag.Meta = dataMeta.FirstOrDefault()?.ConversationalMarketingMeta;
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