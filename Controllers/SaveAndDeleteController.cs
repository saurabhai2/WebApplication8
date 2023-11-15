
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

        public JsonResult SaveMeta(Metatag data, string Column)
        {
            var existingRecord = _context.Metatag.FirstOrDefault(item => item.Id == 1);
            var number = HttpContext.Session.GetInt32("Token");
            if (existingRecord != null)
            {
                if (Column == "Index")
                {
                    existingRecord.IndexMeta = data.IndexMeta;
                }
                else if (Column == "live")
                {
                    existingRecord.liveagentsupportMeta = data.@liveagentsupportMeta;
                }
                if (Column == "WhatsAppBroadcasting")
                {
                    existingRecord.WhatsAppBroadcastingMeta = data.WhatsAppBroadcastingMeta;
                }
                else if (Column == "ReportsAnalytics")
                {
                    existingRecord.ReportsAnalyticsMeta = data.ReportsAnalyticsMeta;
                }
                if (Column == "AutomatedChatBot")
                {
                    existingRecord.AutomatedChatBotMeta = data.AutomatedChatBotMeta;
                }
                else if (Column == "ConversationalMarketing")
                {
                    existingRecord.ConversationalMarketingMeta = data.ConversationalMarketingMeta;
                }
                if (Column == "AutoSegregation")
                {
                    existingRecord.AutoSegregationMeta = data.AutoSegregationMeta;
                }
                else if (Column == "AppMarketing")
                {
                    existingRecord.AppMarketingMeta = data.AppMarketingMeta;
                }
                if (Column == "WhatsAppMarketing")
                {
                    existingRecord.WhatsAppMarketingMeta = data.WhatsAppMarketingMeta;
                }
                else if (Column == "WhatsappCommerce")
                {
                    existingRecord.WhatsappCommerceMeta = data.WhatsappCommerceMeta;
                }
                if (Column == "WhatsappSupport")
                {
                    existingRecord.WhatsappSupportMeta = data.WhatsappSupportMeta;
                }
                else if (Column == "WhatsappAuthentication")
                {
                    existingRecord.WhatsappAuthenticationMeta = data.WhatsappAuthenticationMeta;
                }
                if (Column == "EcommerceRetail")
                {
                    existingRecord.EcommerceRetailMeta = data.EcommerceRetailMeta;
                }
                else if (Column == "Healthcare")
                {
                    existingRecord.HealthcareMeta = data.HealthcareMeta;
                }
                if (Column == "EdTech")
                {
                    existingRecord.EdTechMeta = data.EdTechMeta;
                }
                else if (Column == "BankingBFSI")
                {
                    existingRecord.BankingBFSIMeta = data.BankingBFSIMeta;
                }
                if (Column == "Mediaentertainment")
                {
                    existingRecord.MediaentertainmentMeta = data.MediaentertainmentMeta;
                }
                else if (Column == "FoodBeverage")
                {
                    existingRecord.FoodBeverageMeta = data.FoodBeverageMeta;
                }
                if (Column == "TravelHospitality")
                {
                    existingRecord.TravelHospitalityMeta = data.TravelHospitalityMeta;
                }
                else if (Column == "AboutUs")
                {
                    existingRecord.AboutUsMeta = data.AboutUsMeta;
                }
                if (Column == "WorkWithUs")
                {
                    existingRecord.WorkWithUsMeta = data.WorkWithUsMeta;
                }
                else if (Column == "PartnerWithUs")
                {
                    existingRecord.PartnerWithUsMeta = data.PartnerWithUsMeta;
                }
                if (Column == "Blog")
                {
                    existingRecord.BlogMeta = data.BlogMeta;
                }
                else if (Column == "ContactUs")
                {
                    existingRecord.ContactUsMeta = data.ContactUsMeta;
                }
                if (Column == "KnowledgeCenter")
                {
                    existingRecord.KnowledgeCenterMeta = data.KnowledgeCenterMeta;
                }
                
                


                _context.SaveChanges();

                return Json("true");


            }
            else
            {
                _context.Metatag.Add(data);
                _context.SaveChanges();
                return Json("true");
            }
        }

        public JsonResult SaveSchema(MetatagSchema data, string Column)
        {
            var existingRecord = _context.MetatagSchema.FirstOrDefault(item => item.Id == 1);
            var number = HttpContext.Session.GetInt32("Token");
            if (existingRecord != null)
            {
                if (Column == "Index")
                {
                    existingRecord.IndexMeta = data.IndexMeta;
                }
                else if (Column == "live")
                {
                    existingRecord.liveagentsupportMeta = data.@liveagentsupportMeta;
                }
                if (Column == "WhatsAppBroadcasting")
                {
                    existingRecord.WhatsAppBroadcastingMeta = data.WhatsAppBroadcastingMeta;
                }
                else if (Column == "ReportsAnalytics")
                {
                    existingRecord.ReportsAnalyticsMeta = data.ReportsAnalyticsMeta;
                }
                if (Column == "AutomatedChatBot")
                {
                    existingRecord.AutomatedChatBotMeta = data.AutomatedChatBotMeta;
                }
                else if (Column == "ConversationalMarketing")
                {
                    existingRecord.ConversationalMarketingMeta = data.ConversationalMarketingMeta;
                }
                if (Column == "AutoSegregation")
                {
                    existingRecord.AutoSegregationMeta = data.AutoSegregationMeta;
                }
                else if (Column == "AppMarketing")
                {
                    existingRecord.AppMarketingMeta = data.AppMarketingMeta;
                }
                if (Column == "WhatsAppMarketing")
                {
                    existingRecord.WhatsAppMarketingMeta = data.WhatsAppMarketingMeta;
                }
                else if (Column == "WhatsappCommerce")
                {
                    existingRecord.WhatsappCommerceMeta = data.WhatsappCommerceMeta;
                }
                if (Column == "WhatsappSupport")
                {
                    existingRecord.WhatsappSupportMeta = data.WhatsappSupportMeta;
                }
                else if (Column == "WhatsappAuthentication")
                {
                    existingRecord.WhatsappAuthenticationMeta = data.WhatsappAuthenticationMeta;
                }
                if (Column == "EcommerceRetail")
                {
                    existingRecord.EcommerceRetailMeta = data.EcommerceRetailMeta;
                }
                else if (Column == "Healthcare")
                {
                    existingRecord.HealthcareMeta = data.HealthcareMeta;
                }
                if (Column == "EdTech")
                {
                    existingRecord.EdTechMeta = data.EdTechMeta;
                }
                else if (Column == "BankingBFSI")
                {
                    existingRecord.BankingBFSIMeta = data.BankingBFSIMeta;
                }
                if (Column == "Mediaentertainment")
                {
                    existingRecord.MediaentertainmentMeta = data.MediaentertainmentMeta;
                }
                else if (Column == "FoodBeverage")
                {
                    existingRecord.FoodBeverageMeta = data.FoodBeverageMeta;
                }
                if (Column == "TravelHospitality")
                {
                    existingRecord.TravelHospitalityMeta = data.TravelHospitalityMeta;
                }
                else if (Column == "AboutUs")
                {
                    existingRecord.AboutUsMeta = data.AboutUsMeta;
                }
                if (Column == "WorkWithUs")
                {
                    existingRecord.WorkWithUsMeta = data.WorkWithUsMeta;
                }
                else if (Column == "PartnerWithUs")
                {
                    existingRecord.PartnerWithUsMeta = data.PartnerWithUsMeta;
                }
                if (Column == "Blog")
                {
                    existingRecord.BlogMeta = data.BlogMeta;
                }
                else if (Column == "ContactUs")
                {
                    existingRecord.ContactUsMeta = data.ContactUsMeta;
                }
                if (Column == "KnowledgeCenter")
                {
                    existingRecord.KnowledgeCenterMeta = data.KnowledgeCenterMeta;
                }




                _context.SaveChanges();

                return Json("true");


            }
            else
            {
                _context.MetatagSchema.Add(data);
                _context.SaveChanges();
                return Json("true");
            }
        }

        public JsonResult CheckMeta(MetatagCheck data, string Column)
        {
            var existingRecord = _context.MetatagCheck.FirstOrDefault(item => item.Id == 1);
            var number = HttpContext.Session.GetInt32("Token");
            if (existingRecord != null)
            {
                if (Column == "Index")
                {
                    existingRecord.IndexMeta = data.IndexMeta;
                }
                else if (Column == "live")
                {
                    existingRecord.liveagentsupportMeta = data.@liveagentsupportMeta;
                }
                if (Column == "WhatsAppBroadcasting")
                {
                    existingRecord.WhatsAppBroadcastingMeta = data.WhatsAppBroadcastingMeta;
                }
                else if (Column == "ReportsAnalytics")
                {
                    existingRecord.ReportsAnalyticsMeta = data.ReportsAnalyticsMeta;
                }
                if (Column == "AutomatedChatBot")
                {
                    existingRecord.AutomatedChatBotMeta = data.AutomatedChatBotMeta;
                }
                else if (Column == "ConversationalMarketing")
                {
                    existingRecord.ConversationalMarketingMeta = data.ConversationalMarketingMeta;
                }
                if (Column == "AutoSegregation")
                {
                    existingRecord.AutoSegregationMeta = data.AutoSegregationMeta;
                }
                else if (Column == "AppMarketing")
                {
                    existingRecord.AppMarketingMeta = data.AppMarketingMeta;
                }
                if (Column == "WhatsAppMarketing")
                {
                    existingRecord.WhatsAppMarketingMeta = data.WhatsAppMarketingMeta;
                }
                else if (Column == "WhatsappCommerce")
                {
                    existingRecord.WhatsappCommerceMeta = data.WhatsappCommerceMeta;
                }
                if (Column == "WhatsappSupport")
                {
                    existingRecord.WhatsappSupportMeta = data.WhatsappSupportMeta;
                }
                else if (Column == "WhatsappAuthentication")
                {
                    existingRecord.WhatsappAuthenticationMeta = data.WhatsappAuthenticationMeta;
                }
                if (Column == "EcommerceRetail")
                {
                    existingRecord.EcommerceRetailMeta = data.EcommerceRetailMeta;
                }
                else if (Column == "Healthcare")
                {
                    existingRecord.HealthcareMeta = data.HealthcareMeta;
                }
                if (Column == "EdTech")
                {
                    existingRecord.EdTechMeta = data.EdTechMeta;
                }
                else if (Column == "BankingBFSI")
                {
                    existingRecord.BankingBFSIMeta = data.BankingBFSIMeta;
                }
                if (Column == "Mediaentertainment")
                {
                    existingRecord.MediaentertainmentMeta = data.MediaentertainmentMeta;
                }
                else if (Column == "FoodBeverage")
                {
                    existingRecord.FoodBeverageMeta = data.FoodBeverageMeta;
                }
                if (Column == "TravelHospitality")
                {
                    existingRecord.TravelHospitalityMeta = data.TravelHospitalityMeta;
                }
                else if (Column == "AboutUs")
                {
                    existingRecord.AboutUsMeta = data.AboutUsMeta;
                }
                if (Column == "WorkWithUs")
                {
                    existingRecord.WorkWithUsMeta = data.WorkWithUsMeta;
                }
                else if (Column == "PartnerWithUs")
                {
                    existingRecord.PartnerWithUsMeta = data.PartnerWithUsMeta;
                }
                if (Column == "Blog")
                {
                    existingRecord.BlogMeta = data.BlogMeta;
                }
                else if (Column == "ContactUs")
                {
                    existingRecord.ContactUsMeta = data.ContactUsMeta;
                }
                if (Column == "KnowledgeCenter")
                {
                    existingRecord.KnowledgeCenterMeta = data.KnowledgeCenterMeta;
                }




                _context.SaveChanges();

                return Json("true");


            }
            else
            {
                _context.MetatagCheck.Add(data);
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
