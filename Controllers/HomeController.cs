using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication8.Models;
using WebApplication8.Database;
using System.Text.Json;
using System.Threading.Tasks.Dataflow;

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

        [Route("/")]
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
            var dataCheck = _context.MetatagCheck.ToList();
            if (dataMeta.FirstOrDefault()?.IndexMeta != null)
            {
                ViewBag.Check = dataCheck.FirstOrDefault()?.IndexMeta;
            }
            var dataSchema = _context.MetatagSchema.ToList();
            if (dataSchema.FirstOrDefault()?.IndexMeta != null)
            {
                string? jsonString = dataSchema.FirstOrDefault()?.IndexMeta;
                ViewBag.Schema = JsonSerializer.Deserialize<dynamic>(jsonString);
               
            }
            
            return View();

        }

        [Route("/live-agent-support")]
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
            var dataCheck = _context.MetatagCheck.ToList();
            if (dataMeta.FirstOrDefault()?.liveagentsupportMeta != null)
            {
                ViewBag.Check = dataCheck.FirstOrDefault()?.liveagentsupportMeta;
            }
            var dataSchema = _context.MetatagSchema.ToList();
            if (dataSchema.FirstOrDefault()?.liveagentsupportMeta != null)
            {
                string? jsonString = dataSchema.FirstOrDefault()?.liveagentsupportMeta;
                ViewBag.Schema = JsonSerializer.Deserialize<dynamic>(jsonString);

            }

            return View();
        }

        [Route("/whatsapp-broadcasting")]
        public IActionResult WhatsAppBroadcasting()
        {
            var data = _context.AdminTittle.ToList();
            if (data.FirstOrDefault()?.WhatsAppBroadcasting != null)
            {
                ViewBag.Title = data.FirstOrDefault()?.WhatsAppBroadcasting;
            }
            var dataMeta = _context.Metatag.ToList();
            if (dataMeta.FirstOrDefault()?.WhatsAppBroadcastingMeta != null)
            {
                ViewBag.Meta = dataMeta.FirstOrDefault()?.WhatsAppBroadcastingMeta;
            }
            var dataCheck = _context.MetatagCheck.ToList();
            if (dataMeta.FirstOrDefault()?.WhatsAppBroadcastingMeta != null)
            {
                ViewBag.Check = dataCheck.FirstOrDefault()?.WhatsAppBroadcastingMeta;
            }
            var dataSchema = _context.MetatagSchema.ToList();
            if (dataSchema.FirstOrDefault()?.WhatsAppBroadcastingMeta != null)
            {
                string? jsonString = dataSchema.FirstOrDefault()?.WhatsAppBroadcastingMeta;
                ViewBag.Schema = JsonSerializer.Deserialize<dynamic>(jsonString);

            }
            return View();
        }

        [Route("/reports-and-analytics")]
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
            var dataCheck = _context.MetatagCheck.ToList();
            if (dataMeta.FirstOrDefault()?.ReportsAnalyticsMeta != null)
            {
                ViewBag.Check = dataCheck.FirstOrDefault()?.ReportsAnalyticsMeta;
            }
            var dataSchema = _context.MetatagSchema.ToList();
            if (dataSchema.FirstOrDefault()?.ReportsAnalyticsMeta != null)
            {
                string? jsonString = dataSchema.FirstOrDefault()?.ReportsAnalyticsMeta;
                ViewBag.Schema = JsonSerializer.Deserialize<dynamic>(jsonString);

            }

            return View();
        }

        [Route("/automated-chatbot")]
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
            var dataCheck = _context.MetatagCheck.ToList();
            if (dataMeta.FirstOrDefault()?.ReportsAnalyticsMeta != null)
            {
                ViewBag.Check = dataCheck.FirstOrDefault()?.ReportsAnalyticsMeta;
            }
            var dataSchema = _context.MetatagSchema.ToList();
            if (dataSchema.FirstOrDefault()?.ReportsAnalyticsMeta != null)
            {
                string? jsonString = dataSchema.FirstOrDefault()?.ReportsAnalyticsMeta;
                ViewBag.Schema = JsonSerializer.Deserialize<dynamic>(jsonString);

            }
            return View();
        }

        [Route("/conversational-marketing")]
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
            var dataCheck = _context.MetatagCheck.ToList();
            if (dataMeta.FirstOrDefault()?.ConversationalMarketingMeta != null)
            {
                ViewBag.Check = dataCheck.FirstOrDefault()?.ConversationalMarketingMeta;
            }
            var dataSchema = _context.MetatagSchema.ToList();
            if (dataSchema.FirstOrDefault()?.ConversationalMarketingMeta != null)
            {
                string? jsonString = dataSchema.FirstOrDefault()?.ConversationalMarketingMeta;
                ViewBag.Schema = JsonSerializer.Deserialize<dynamic>(jsonString);

            }

            return View();
        }

        [Route("/auto-segregation")]
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
            var dataCheck = _context.MetatagCheck.ToList();
            if (dataMeta.FirstOrDefault()?.AutoSegregationMeta != null)
            {
                ViewBag.Check = dataCheck.FirstOrDefault()?.AutoSegregationMeta;
            }
            var dataSchema = _context.MetatagSchema.ToList();
            if (dataSchema.FirstOrDefault()?.AutoSegregationMeta != null)
            {
                string? jsonString = dataSchema.FirstOrDefault()?.AutoSegregationMeta;
                ViewBag.Schema = JsonSerializer.Deserialize<dynamic>(jsonString);

            }   
            return View();
        }

        [Route("/app-marketing")]
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
            var dataCheck = _context.MetatagCheck.ToList();
            if (dataMeta.FirstOrDefault()?.AppMarketingMeta != null)
            {
                ViewBag.Check = dataCheck.FirstOrDefault()?.AppMarketingMeta;
            }
            var dataSchema = _context.MetatagSchema.ToList();
            if (dataSchema.FirstOrDefault()?.AppMarketingMeta != null)
            {
                string? jsonString = dataSchema.FirstOrDefault()?.AppMarketingMeta;
                ViewBag.Schema = JsonSerializer.Deserialize<dynamic>(jsonString);

            }
            return View();
        }

        [Route("/whatsapp-marketing")]
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
            var dataCheck = _context.MetatagCheck.ToList();
            if (dataMeta.FirstOrDefault()?.WhatsAppMarketingMeta != null)
            {
                ViewBag.Check = dataCheck.FirstOrDefault()?.WhatsAppMarketingMeta;
            }
            var dataSchema = _context.MetatagSchema.ToList();
            if (dataSchema.FirstOrDefault()?.WhatsAppMarketingMeta != null)
            {
                string? jsonString = dataSchema.FirstOrDefault()?.WhatsAppMarketingMeta;
                ViewBag.Schema = JsonSerializer.Deserialize<dynamic>(jsonString);

            }
            return View();
        }

        [Route("/whatsapp-commerce")]
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
            var dataCheck = _context.MetatagCheck.ToList();
            if (dataMeta.FirstOrDefault()?.WhatsappCommerceMeta != null)
            {
                ViewBag.Check = dataCheck.FirstOrDefault()?.WhatsappCommerceMeta;
            }
            var dataSchema = _context.MetatagSchema.ToList();
            if (dataSchema.FirstOrDefault()?.WhatsappCommerceMeta != null)
            {
                string? jsonString = dataSchema.FirstOrDefault()?.WhatsappCommerceMeta;
                ViewBag.Schema = JsonSerializer.Deserialize<dynamic>(jsonString);

            }
            return View();
        }

        [Route("/whatsapp-support")]
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
            var dataCheck = _context.MetatagCheck.ToList();
            if (dataMeta.FirstOrDefault()?.WhatsappSupportMeta != null)
            {
                ViewBag.Check = dataCheck.FirstOrDefault()?.WhatsappSupportMeta;
            }
            var dataSchema = _context.MetatagSchema.ToList();
            if (dataSchema.FirstOrDefault()?.WhatsappSupportMeta != null)
            {
                string? jsonString = dataSchema.FirstOrDefault()?.WhatsappSupportMeta;
                ViewBag.Schema = JsonSerializer.Deserialize<dynamic>(jsonString);

            }
            return View();
        }

        [Route("/whatsapp-authentication")]
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
            var dataCheck = _context.MetatagCheck.ToList();
            if (dataMeta.FirstOrDefault()?.WhatsappAuthenticationMeta != null)
            {
                ViewBag.Check = dataCheck.FirstOrDefault()?.WhatsappAuthenticationMeta;
            }
            var dataSchema = _context.MetatagSchema.ToList();
            if (dataSchema.FirstOrDefault()?.WhatsappAuthenticationMeta != null)
            {
                string? jsonString = dataSchema.FirstOrDefault()?.WhatsappAuthenticationMeta;
                ViewBag.Schema = JsonSerializer.Deserialize<dynamic>(jsonString);

            }
            return View();
        }

        [Route("/ecommerce-industry")]
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
            var dataCheck = _context.MetatagCheck.ToList();
            if (dataMeta.FirstOrDefault()?.EcommerceRetailMeta != null)
            {
                ViewBag.Check = dataCheck.FirstOrDefault()?.EcommerceRetailMeta;
            }
            var dataSchema = _context.MetatagSchema.ToList();
            if (dataSchema.FirstOrDefault()?.EcommerceRetailMeta != null)
            {
                string? jsonString = dataSchema.FirstOrDefault()?.EcommerceRetailMeta;
                ViewBag.Schema = JsonSerializer.Deserialize<dynamic>(jsonString);

            }
            return View();
        }

        [Route("/healthcare-industry")]
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
            var dataCheck = _context.MetatagCheck.ToList();
            if (dataMeta.FirstOrDefault()?.HealthcareMeta != null)
            {
                ViewBag.Check = dataCheck.FirstOrDefault()?.HealthcareMeta;
            }
            var dataSchema = _context.MetatagSchema.ToList();
            if (dataSchema.FirstOrDefault()?.HealthcareMeta != null)
            {
                string? jsonString = dataSchema.FirstOrDefault()?.HealthcareMeta;
                ViewBag.Schema = JsonSerializer.Deserialize<dynamic>(jsonString);

            }
            return View();
        }

        [Route("/edtech-industry")]
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
            var dataCheck = _context.MetatagCheck.ToList();
            if (dataMeta.FirstOrDefault()?.EdTechMeta != null)
            {
                ViewBag.Check = dataCheck.FirstOrDefault()?.EdTechMeta;
            }
            var dataSchema = _context.MetatagSchema.ToList();
            if (dataSchema.FirstOrDefault()?.EdTechMeta != null)
            {
                string? jsonString = dataSchema.FirstOrDefault()?.EdTechMeta;
                ViewBag.Schema = JsonSerializer.Deserialize<dynamic>(jsonString);

            }
            return View();
        }

        [Route("/banking-industry")]
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
            var dataCheck = _context.MetatagCheck.ToList();
            if (dataMeta.FirstOrDefault()?.BankingBFSIMeta != null)
            {
                ViewBag.Check = dataCheck.FirstOrDefault()?.BankingBFSIMeta;
            }
            var dataSchema = _context.MetatagSchema.ToList();
            if (dataSchema.FirstOrDefault()?.BankingBFSIMeta != null)
            {
                string? jsonString = dataSchema.FirstOrDefault()?.BankingBFSIMeta;
                ViewBag.Schema = JsonSerializer.Deserialize<dynamic>(jsonString);

            }
            return View();
        }

        [Route("/media-entertainment-industry")]
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
            var dataCheck = _context.MetatagCheck.ToList();
            if (dataMeta.FirstOrDefault()?.MediaentertainmentMeta != null)
            {
                ViewBag.Check = dataCheck.FirstOrDefault()?.MediaentertainmentMeta;
            }
            var dataSchema = _context.MetatagSchema.ToList();
            if (dataSchema.FirstOrDefault()?.MediaentertainmentMeta != null)
            {
                string? jsonString = dataSchema.FirstOrDefault()?.MediaentertainmentMeta;
                ViewBag.Schema = JsonSerializer.Deserialize<dynamic>(jsonString);

            }
            return View();
        }

        [Route("/food-and-beverage-industry")]
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
            var dataCheck = _context.MetatagCheck.ToList();
            if (dataMeta.FirstOrDefault()?.FoodBeverageMeta != null)
            {
                ViewBag.Check = dataCheck.FirstOrDefault()?.FoodBeverageMeta;
            }
            var dataSchema = _context.MetatagSchema.ToList();
            if (dataSchema.FirstOrDefault()?.FoodBeverageMeta != null)
            {
                string? jsonString = dataSchema.FirstOrDefault()?.FoodBeverageMeta;
                ViewBag.Schema = JsonSerializer.Deserialize<dynamic>(jsonString);

            }
            return View();
        }

        [Route("/travel-and-hospitality-industry")]
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
            var dataCheck = _context.MetatagCheck.ToList();
            if (dataMeta.FirstOrDefault()?.TravelHospitalityMeta != null)
            {
                ViewBag.Check = dataCheck.FirstOrDefault()?.TravelHospitalityMeta;
            }
            var dataSchema = _context.MetatagSchema.ToList();
            if (dataSchema.FirstOrDefault()?.TravelHospitalityMeta != null)
            {
                string? jsonString = dataSchema.FirstOrDefault()?.TravelHospitalityMeta;
                ViewBag.Schema = JsonSerializer.Deserialize<dynamic>(jsonString);

            }
            return View();
        }

        [Route("/about")]
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
            var dataCheck = _context.MetatagCheck.ToList();
            if (dataMeta.FirstOrDefault()?.AboutUsMeta != null)
            {
                ViewBag.Check = dataCheck.FirstOrDefault()?.AboutUsMeta;
            }
            var dataSchema = _context.MetatagSchema.ToList();
            if (dataSchema.FirstOrDefault()?.AboutUsMeta != null)
            {
                string? jsonString = dataSchema.FirstOrDefault()?.AboutUsMeta;
                ViewBag.Schema = JsonSerializer.Deserialize<dynamic>(jsonString);

            }
            return View();
        }

        [Route("/work-with-us")]
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
            var dataCheck = _context.MetatagCheck.ToList();
            if (dataMeta.FirstOrDefault()?.WorkWithUsMeta != null)
            {
                ViewBag.Check = dataCheck.FirstOrDefault()?.WorkWithUsMeta;
            }
            var dataSchema = _context.MetatagSchema.ToList();
            if (dataSchema.FirstOrDefault()?.WorkWithUsMeta != null)
            {
                string? jsonString = dataSchema.FirstOrDefault()?.WorkWithUsMeta;
                ViewBag.Schema = JsonSerializer.Deserialize<dynamic>(jsonString);

            }
            return View();
        }

        [Route("/partner-with-us")]
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
            var dataCheck = _context.MetatagCheck.ToList();
            if (dataMeta.FirstOrDefault()?.PartnerWithUsMeta != null)
            {
                ViewBag.Check = dataCheck.FirstOrDefault()?.PartnerWithUsMeta;
            }
            var dataSchema = _context.MetatagSchema.ToList();
            if (dataSchema.FirstOrDefault()?.PartnerWithUsMeta != null)
            {
                string? jsonString = dataSchema.FirstOrDefault()?.PartnerWithUsMeta;
                ViewBag.Schema = JsonSerializer.Deserialize<dynamic>(jsonString);

            }
            return View();
        }

        [Route("/blog")]
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
            var dataCheck = _context.MetatagCheck.ToList();
            if (dataMeta.FirstOrDefault()?.BlogMeta != null)
            {
                ViewBag.Check = dataCheck.FirstOrDefault()?.BlogMeta;
            }
            var dataSchema = _context.MetatagSchema.ToList();
            if (dataSchema.FirstOrDefault()?.BlogMeta != null)
            {
                string? jsonString = dataSchema.FirstOrDefault()?.BlogMeta;
                ViewBag.Schema = JsonSerializer.Deserialize<dynamic>(jsonString);

            }
            return View();
        }

        [Route("/contact")]
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
            var dataCheck = _context.MetatagCheck.ToList();
            if (dataMeta.FirstOrDefault()?.ContactUsMeta != null)
            {
                ViewBag.Check = dataCheck.FirstOrDefault()?.ContactUsMeta;
            }
            var dataSchema = _context.MetatagSchema.ToList();
            if (dataSchema.FirstOrDefault()?.ContactUsMeta != null)
            {
                string? jsonString = dataSchema.FirstOrDefault()?.ContactUsMeta;
                ViewBag.Schema = JsonSerializer.Deserialize<dynamic>(jsonString);

            }
            return View();
        }

        [Route("/knowledge-center")]
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
            var dataCheck = _context.MetatagCheck.ToList();
            if (dataMeta.FirstOrDefault()?.KnowledgeCenterMeta != null)
            {
                ViewBag.Check = dataCheck.FirstOrDefault()?.KnowledgeCenterMeta;
            }
            var dataSchema = _context.MetatagSchema.ToList();
            if (dataSchema.FirstOrDefault()?.KnowledgeCenterMeta != null)
            {
                string? jsonString = dataSchema.FirstOrDefault()?.KnowledgeCenterMeta;
                ViewBag.Schema = JsonSerializer.Deserialize<dynamic>(jsonString);

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


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}