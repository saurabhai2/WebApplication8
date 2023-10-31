using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication8.Models
{
    public class Tittle
    {
        [Key]
        
        public int Id { get; set; }
        [Required]
        [DefaultValue("Whatsapp Chatbot | Verified WhatsApp Business API by Anantya")]
        public string Index { get; set; }
        [Required]
        [DefaultValue("Live Agent Assistant for WhatsApp | Anantya AI Agent Assist")]
        public string liveagentsupport { get; set; }
        [Required]
        [DefaultValue("WhatsApp Broadcasting | Boost Your Business Reach - Anantya")]
        public string WhatsAppBroadcasting { get; set; }

        [Required]
        [DefaultValue("Whatsapp Reports and Analytics to Track Conversions - Anantya")]
        public string ReportsAnalytics { get; set; }
         public string AutomatedChatBot { get; set; }
        [Required]
        public string ConversationalMarketing { get; set; }
        [Required]
        public string AutoSegregation { get; set; }
        public string AppMarketing { get; set; }
        [Required]
        public string WhatsAppMarketing { get; set; }
        public string WhatsappCommerce { get; set; }
        [Required]
        public string WhatsappSupport { get; set; }
        [Required]
        public string WhatsappAuthentication { get; set; }
        public string EcommerceRetail { get; set; }
        [Required]
        public string Healthcare { get; set; }
        [Required]
        public string EdTech { get; set; }
        public string BankingBFSI { get; set; }
        [Required]
        public string Mediaentertainment { get; set; }
        [Required]
        public string FoodBeverage { get; set; }
        public string TravelHospitality { get; set; }
        [Required]
        public string AboutUs { get; set; }
        [Required]
        public string WorkWithUs { get; set; }
        public string PartnerWithUs { get; set; }
        [Required]
        public string Blog { get; set; }
        [Required]
        public string ContactUs { get; set; }
        public string KnowledgeCenter { get; set; }
        [Required]
        public string whatsappbusinessappvswhatsappbusinessapi { get; set; }
        [Required]
        public string whatsappmarketingstrategiestodrivesales { get; set; }

        public string reshapingcustomerengagementonwhatsapp { get; set; }

    }
}
