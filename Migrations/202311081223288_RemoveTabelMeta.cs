namespace WebApplication8.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveTabelMeta : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Metatags", "IndexName");
            DropColumn("dbo.Metatags", "liveagentsupportName");
            DropColumn("dbo.Metatags", "WhatsAppBroadcastingName");
            DropColumn("dbo.Metatags", "ReportsAnalyticsName");
            DropColumn("dbo.Metatags", "AutomatedChatBotName");
            DropColumn("dbo.Metatags", "ConversationalMarketingName");
            DropColumn("dbo.Metatags", "AutoSegregationName");
            DropColumn("dbo.Metatags", "AppMarketingName");
            DropColumn("dbo.Metatags", "WhatsAppMarketingName");
            DropColumn("dbo.Metatags", "WhatsappCommerceName");
            DropColumn("dbo.Metatags", "WhatsappSupportName");
            DropColumn("dbo.Metatags", "WhatsappAuthenticationName");
            DropColumn("dbo.Metatags", "EcommerceRetailName");
            DropColumn("dbo.Metatags", "HealthcareName");
            DropColumn("dbo.Metatags", "EdTechName");
            DropColumn("dbo.Metatags", "BankingBFSIName");
            DropColumn("dbo.Metatags", "MediaentertainmentName");
            DropColumn("dbo.Metatags", "FoodBeverageName");
            DropColumn("dbo.Metatags", "TravelHospitalityName");
            DropColumn("dbo.Metatags", "AboutUsName");
            DropColumn("dbo.Metatags", "WorkWithUsName");
            DropColumn("dbo.Metatags", "PartnerWithUsName");
            DropColumn("dbo.Metatags", "BlogName");
            DropColumn("dbo.Metatags", "ContactUsName");
            DropColumn("dbo.Metatags", "KnowledgeCenterName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Metatags", "KnowledgeCenterName", c => c.String());
            AddColumn("dbo.Metatags", "ContactUsName", c => c.String());
            AddColumn("dbo.Metatags", "BlogName", c => c.String());
            AddColumn("dbo.Metatags", "PartnerWithUsName", c => c.String());
            AddColumn("dbo.Metatags", "WorkWithUsName", c => c.String());
            AddColumn("dbo.Metatags", "AboutUsName", c => c.String());
            AddColumn("dbo.Metatags", "TravelHospitalityName", c => c.String());
            AddColumn("dbo.Metatags", "FoodBeverageName", c => c.String());
            AddColumn("dbo.Metatags", "MediaentertainmentName", c => c.String());
            AddColumn("dbo.Metatags", "BankingBFSIName", c => c.String());
            AddColumn("dbo.Metatags", "EdTechName", c => c.String());
            AddColumn("dbo.Metatags", "HealthcareName", c => c.String());
            AddColumn("dbo.Metatags", "EcommerceRetailName", c => c.String());
            AddColumn("dbo.Metatags", "WhatsappAuthenticationName", c => c.String());
            AddColumn("dbo.Metatags", "WhatsappSupportName", c => c.String());
            AddColumn("dbo.Metatags", "WhatsappCommerceName", c => c.String());
            AddColumn("dbo.Metatags", "WhatsAppMarketingName", c => c.String());
            AddColumn("dbo.Metatags", "AppMarketingName", c => c.String());
            AddColumn("dbo.Metatags", "AutoSegregationName", c => c.String());
            AddColumn("dbo.Metatags", "ConversationalMarketingName", c => c.String());
            AddColumn("dbo.Metatags", "AutomatedChatBotName", c => c.String());
            AddColumn("dbo.Metatags", "ReportsAnalyticsName", c => c.String());
            AddColumn("dbo.Metatags", "WhatsAppBroadcastingName", c => c.String());
            AddColumn("dbo.Metatags", "liveagentsupportName", c => c.String());
            AddColumn("dbo.Metatags", "IndexName", c => c.String());
        }
    }
}
