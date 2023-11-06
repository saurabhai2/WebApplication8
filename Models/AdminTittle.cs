using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication8.Models
{
    public class AdminTittle
    {
        [Key]
        
        public int Id { get; set; }
        
        [DefaultValue("Whatsapp Chatbot | Verified WhatsApp Business API by Anantya")]
        public string Index { get; set; }
        
        [DefaultValue("Live Agent Assistant for WhatsApp | Anantya AI Agent Assist")]
        public string liveagentsupport { get; set; }
        
        [DefaultValue("WhatsApp Broadcasting | Boost Your Business Reach - Anantya")]
        public string WhatsAppBroadcasting { get; set; }

        
        [DefaultValue("Whatsapp Reports and Analytics to Track Conversions - Anantya")]
        public string ReportsAnalytics { get; set; }
         public string AutomatedChatBot { get; set; }
        
        public string ConversationalMarketing { get; set; }
        
        public string AutoSegregation { get; set; }
        public string AppMarketing { get; set; }
        
        public string WhatsAppMarketing { get; set; }
        public string WhatsappCommerce { get; set; }
        
        public string WhatsappSupport { get; set; }
        
        public string WhatsappAuthentication { get; set; }
        public string EcommerceRetail { get; set; }
        
        public string Healthcare { get; set; }
        
        public string EdTech { get; set; }
        public string BankingBFSI { get; set; }
        
        public string Mediaentertainment { get; set; }
        
        public string FoodBeverage { get; set; }
        public string TravelHospitality { get; set; }
        
        public string AboutUs { get; set; }
        
        public string WorkWithUs { get; set; }
        public string PartnerWithUs { get; set; }
        
        public string Blog { get; set; }
        
        public string ContactUs { get; set; }
        public string KnowledgeCenter { get; set; }
        
        public string whatsappbusinessappvswhatsappbusinessapi { get; set; }
       
        public string whatsappmarketingstrategiestodrivesales { get; set; }

        public string reshapingcustomerengagementonwhatsapp { get; set; }

        
    }
}
