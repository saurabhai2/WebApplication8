
using Microsoft.AspNetCore.Mvc;

using WebApplication8.Database;
using WebApplication8.Models;

namespace WebApplication8.Controllers
{
    public class SaveAndDeleteController : Controller
    {
        
        private readonly AnantyaDbContext _context;

        public SaveAndDeleteController(AnantyaDbContext context)
        {
            _context = context;
        }
        public JsonResult Save(AdminTittle data, string Column)
        {
            var existingRecord = _context.AdminTittle.FirstOrDefault(item => item.Id == 1);
            var number = HttpContext.Session.GetInt32("Token");
            if (existingRecord != null)
            {
                if (Column == "Index")
                {
                    existingRecord.Index = data.Index;
                }
                else if (Column == "live")
                {
                    existingRecord.liveagentsupport = data.@liveagentsupport;
                }
                if (Column == "WhatsAppBroadcasting")
                {
                    existingRecord.WhatsAppBroadcasting = data.WhatsAppBroadcasting;
                }
                else if (Column == "ReportsAnalytics")
                {
                    existingRecord.ReportsAnalytics = data.ReportsAnalytics;
                }
                if (Column == "AutomatedChatBot")
                {
                    existingRecord.AutomatedChatBot = data.AutomatedChatBot;
                }
                else if (Column == "ConversationalMarketing")
                {
                    existingRecord.ConversationalMarketing = data.ConversationalMarketing;
                }
                if (Column == "AutoSegregation")
                {
                    existingRecord.AutoSegregation = data.AutoSegregation;
                }
                else if (Column == "AppMarketing")
                {
                    existingRecord.AppMarketing = data.AppMarketing;
                }
                if (Column == "WhatsAppMarketing")
                {
                    existingRecord.WhatsAppMarketing = data.WhatsAppMarketing;
                }
                else if (Column == "WhatsappCommerce")
                {
                    existingRecord.WhatsappCommerce = data.WhatsappCommerce;
                }
                if (Column == "WhatsappSupport")
                {
                    existingRecord.WhatsappSupport = data.WhatsappSupport;
                }
                else if (Column == "WhatsappAuthentication")
                {
                    existingRecord.WhatsappAuthentication = data.WhatsappAuthentication;
                }
                if (Column == "EcommerceRetail")
                {
                    existingRecord.EcommerceRetail = data.EcommerceRetail;
                }
                else if (Column == "Healthcare")
                {
                    existingRecord.Healthcare = data.Healthcare;
                }
                if (Column == "EdTech")
                {
                    existingRecord.EdTech = data.EdTech;
                }
                else if (Column == "BankingBFSI")
                {
                    existingRecord.BankingBFSI = data.BankingBFSI;
                }
                if (Column == "Mediaentertainment")
                {
                    existingRecord.Mediaentertainment = data.Mediaentertainment;
                }
                else if (Column == "FoodBeverage")
                {
                    existingRecord.FoodBeverage = data.FoodBeverage;
                }
                if (Column == "TravelHospitality")
                {
                    existingRecord.TravelHospitality = data.TravelHospitality;
                }
                else if (Column == "AboutUs")
                {
                    existingRecord.AboutUs = data.AboutUs;
                }
                if (Column == "WorkWithUs")
                {
                    existingRecord.WorkWithUs = data.WorkWithUs;
                }
                else if (Column == "PartnerWithUs")
                {
                    existingRecord.PartnerWithUs = data.PartnerWithUs;
                }
                if (Column == "Blog")
                {
                    existingRecord.Blog = data.Blog;
                }
                else if (Column == "ContactUs")
                {
                    existingRecord.ContactUs = data.ContactUs;
                }
                if (Column == "KnowledgeCenter")
                {
                    existingRecord.KnowledgeCenter = data.KnowledgeCenter;
                }
                else if (Column == "PartnerWithUs")
                {
                    existingRecord.PartnerWithUs = data.PartnerWithUs;
                }
                if (Column == "WorkWithUs")
                {
                    existingRecord.WorkWithUs = data.WorkWithUs;
                }
                else if (Column == "PartnerWithUs")
                {
                    existingRecord.PartnerWithUs = data.PartnerWithUs;
                }


            _context.SaveChanges();

                return Json("true");


            }
            else
            {
                _context.AdminTittle.Add(data);
                _context.SaveChanges();
                return Json("true");
            }
        }

        public JsonResult Delete(AdminTittle data, string Column)
        {
            var existingRecord = _context.AdminTittle.FirstOrDefault(item => item.Id == 1);
            var number = HttpContext.Session.GetInt32("Token");
            if (existingRecord != null)
            {
                if (Column == "Index")
                {
                    existingRecord.Index = data.Index;
                }
                else if (Column == "live")
                {
                    existingRecord.liveagentsupport = data.@liveagentsupport;
                }
                if (Column == "WhatsAppBroadcasting")
                {
                    existingRecord.WhatsAppBroadcasting = data.WhatsAppBroadcasting;
                }
                else if (Column == "ReportsAnalytics")
                {
                    existingRecord.ReportsAnalytics = data.ReportsAnalytics;
                }
                if (Column == "AutomatedChatBot")
                {
                    existingRecord.AutomatedChatBot = data.AutomatedChatBot;
                }
                else if (Column == "ConversationalMarketing")
                {
                    existingRecord.ConversationalMarketing = data.ConversationalMarketing;
                }
                if (Column == "AutoSegregation")
                {
                    existingRecord.AutoSegregation = data.AutoSegregation;
                }
                else if (Column == "AppMarketing")
                {
                    existingRecord.AppMarketing = data.AppMarketing;
                }
                if (Column == "WhatsAppMarketing")
                {
                    existingRecord.WhatsAppMarketing = data.WhatsAppMarketing;
                }
                else if (Column == "WhatsappCommerce")
                {
                    existingRecord.WhatsappCommerce = data.WhatsappCommerce;
                }
                if (Column == "WhatsappSupport")
                {
                    existingRecord.WhatsappSupport = data.WhatsappSupport;
                }
                else if (Column == "WhatsappAuthentication")
                {
                    existingRecord.WhatsappAuthentication = data.WhatsappAuthentication;
                }
                if (Column == "EcommerceRetail")
                {
                    existingRecord.EcommerceRetail = data.EcommerceRetail;
                }
                else if (Column == "Healthcare")
                {
                    existingRecord.Healthcare = data.Healthcare;
                }
                if (Column == "EdTech")
                {
                    existingRecord.EdTech = data.EdTech;
                }
                else if (Column == "BankingBFSI")
                {
                    existingRecord.BankingBFSI = data.BankingBFSI;
                }
                if (Column == "Mediaentertainment")
                {
                    existingRecord.Mediaentertainment = data.Mediaentertainment;
                }
                else if (Column == "FoodBeverage")
                {
                    existingRecord.FoodBeverage = data.FoodBeverage;
                }
                if (Column == "TravelHospitality")
                {
                    existingRecord.TravelHospitality = data.TravelHospitality;
                }
                else if (Column == "AboutUs")
                {
                    existingRecord.AboutUs = data.AboutUs;
                }
                if (Column == "WorkWithUs")
                {
                    existingRecord.WorkWithUs = data.WorkWithUs;
                }
                else if (Column == "PartnerWithUs")
                {
                    existingRecord.PartnerWithUs = data.PartnerWithUs;
                }
                if (Column == "Blog")
                {
                    existingRecord.Blog = data.Blog;
                }
                else if (Column == "ContactUs")
                {
                    existingRecord.ContactUs = data.ContactUs;
                }
                if (Column == "KnowledgeCenter")
                {
                    existingRecord.KnowledgeCenter = data.KnowledgeCenter;
                }
                else if (Column == "PartnerWithUs")
                {
                    existingRecord.PartnerWithUs = data.PartnerWithUs;
                }
                if (Column == "WorkWithUs")
                {
                    existingRecord.WorkWithUs = data.WorkWithUs;
                }
                else if (Column == "PartnerWithUs")
                {
                    existingRecord.PartnerWithUs = data.PartnerWithUs;
                }


                _context.SaveChanges();

                return Json("true");


            }
            else
            {
                _context.AdminTittle.Add(data);
                _context.SaveChanges();
                return Json("true");

            }
        }
    }

    
}
