namespace WebApplication8.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTabless3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Metatags",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Index = c.String(),
                        liveagentsupport = c.String(),
                        WhatsAppBroadcasting = c.String(),
                        ReportsAnalytics = c.String(),
                        AutomatedChatBot = c.String(),
                        ConversationalMarketing = c.String(),
                        AutoSegregation = c.String(),
                        AppMarketing = c.String(),
                        WhatsAppMarketing = c.String(),
                        WhatsappCommerce = c.String(),
                        WhatsappSupport = c.String(),
                        WhatsappAuthentication = c.String(),
                        EcommerceRetail = c.String(),
                        Healthcare = c.String(),
                        EdTech = c.String(),
                        BankingBFSI = c.String(),
                        Mediaentertainment = c.String(),
                        FoodBeverage = c.String(),
                        TravelHospitality = c.String(),
                        AboutUs = c.String(),
                        WorkWithUs = c.String(),
                        PartnerWithUs = c.String(),
                        Blog = c.String(),
                        ContactUs = c.String(),
                        KnowledgeCenter = c.String(),
                        IndexName = c.String(),
                        liveagentsupportName = c.String(),
                        WhatsAppBroadcastingName = c.String(),
                        ReportsAnalyticsName = c.String(),
                        AutomatedChatBotName = c.String(),
                        ConversationalMarketingName = c.String(),
                        AutoSegregationName = c.String(),
                        AppMarketingName = c.String(),
                        WhatsAppMarketingName = c.String(),
                        WhatsappCommerceName = c.String(),
                        WhatsappSupportName = c.String(),
                        WhatsappAuthenticationName = c.String(),
                        EcommerceRetailName = c.String(),
                        HealthcareName = c.String(),
                        EdTechName = c.String(),
                        BankingBFSIName = c.String(),
                        MediaentertainmentName = c.String(),
                        FoodBeverageName = c.String(),
                        TravelHospitalityName = c.String(),
                        AboutUsName = c.String(),
                        WorkWithUsName = c.String(),
                        PartnerWithUsName = c.String(),
                        BlogName = c.String(),
                        ContactUsName = c.String(),
                        KnowledgeCenterName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Metatags");
        }
    }
}
