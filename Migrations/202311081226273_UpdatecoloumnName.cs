namespace WebApplication8.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatecoloumnName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Metatags", "IndexMeta", c => c.String());
            AddColumn("dbo.Metatags", "liveagentsupportMeta", c => c.String());
            AddColumn("dbo.Metatags", "WhatsAppBroadcastingMeta", c => c.String());
            AddColumn("dbo.Metatags", "ReportsAnalyticsMeta", c => c.String());
            AddColumn("dbo.Metatags", "AutomatedChatBotMeta", c => c.String());
            AddColumn("dbo.Metatags", "ConversationalMarketingMeta", c => c.String());
            AddColumn("dbo.Metatags", "AutoSegregationMeta", c => c.String());
            AddColumn("dbo.Metatags", "AppMarketingMeta", c => c.String());
            AddColumn("dbo.Metatags", "WhatsAppMarketingMeta", c => c.String());
            AddColumn("dbo.Metatags", "WhatsappCommerceMeta", c => c.String());
            AddColumn("dbo.Metatags", "WhatsappSupportMeta", c => c.String());
            AddColumn("dbo.Metatags", "WhatsappAuthenticationMeta", c => c.String());
            AddColumn("dbo.Metatags", "EcommerceRetailMeta", c => c.String());
            AddColumn("dbo.Metatags", "HealthcareMeta", c => c.String());
            AddColumn("dbo.Metatags", "EdTechMeta", c => c.String());
            AddColumn("dbo.Metatags", "BankingBFSIMeta", c => c.String());
            AddColumn("dbo.Metatags", "MediaentertainmentMeta", c => c.String());
            AddColumn("dbo.Metatags", "FoodBeverageMeta", c => c.String());
            AddColumn("dbo.Metatags", "TravelHospitalityMeta", c => c.String());
            AddColumn("dbo.Metatags", "AboutUsMeta", c => c.String());
            AddColumn("dbo.Metatags", "WorkWithUsMeta", c => c.String());
            AddColumn("dbo.Metatags", "PartnerWithUsMeta", c => c.String());
            AddColumn("dbo.Metatags", "BlogMeta", c => c.String());
            AddColumn("dbo.Metatags", "ContactUsMeta", c => c.String());
            AddColumn("dbo.Metatags", "KnowledgeCenterMeta", c => c.String());
            DropColumn("dbo.Metatags", "Index");
            DropColumn("dbo.Metatags", "liveagentsupport");
            DropColumn("dbo.Metatags", "WhatsAppBroadcasting");
            DropColumn("dbo.Metatags", "ReportsAnalytics");
            DropColumn("dbo.Metatags", "AutomatedChatBot");
            DropColumn("dbo.Metatags", "ConversationalMarketing");
            DropColumn("dbo.Metatags", "AutoSegregation");
            DropColumn("dbo.Metatags", "AppMarketing");
            DropColumn("dbo.Metatags", "WhatsAppMarketing");
            DropColumn("dbo.Metatags", "WhatsappCommerce");
            DropColumn("dbo.Metatags", "WhatsappSupport");
            DropColumn("dbo.Metatags", "WhatsappAuthentication");
            DropColumn("dbo.Metatags", "EcommerceRetail");
            DropColumn("dbo.Metatags", "Healthcare");
            DropColumn("dbo.Metatags", "EdTech");
            DropColumn("dbo.Metatags", "BankingBFSI");
            DropColumn("dbo.Metatags", "Mediaentertainment");
            DropColumn("dbo.Metatags", "FoodBeverage");
            DropColumn("dbo.Metatags", "TravelHospitality");
            DropColumn("dbo.Metatags", "AboutUs");
            DropColumn("dbo.Metatags", "WorkWithUs");
            DropColumn("dbo.Metatags", "PartnerWithUs");
            DropColumn("dbo.Metatags", "Blog");
            DropColumn("dbo.Metatags", "ContactUs");
            DropColumn("dbo.Metatags", "KnowledgeCenter");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Metatags", "KnowledgeCenter", c => c.String());
            AddColumn("dbo.Metatags", "ContactUs", c => c.String());
            AddColumn("dbo.Metatags", "Blog", c => c.String());
            AddColumn("dbo.Metatags", "PartnerWithUs", c => c.String());
            AddColumn("dbo.Metatags", "WorkWithUs", c => c.String());
            AddColumn("dbo.Metatags", "AboutUs", c => c.String());
            AddColumn("dbo.Metatags", "TravelHospitality", c => c.String());
            AddColumn("dbo.Metatags", "FoodBeverage", c => c.String());
            AddColumn("dbo.Metatags", "Mediaentertainment", c => c.String());
            AddColumn("dbo.Metatags", "BankingBFSI", c => c.String());
            AddColumn("dbo.Metatags", "EdTech", c => c.String());
            AddColumn("dbo.Metatags", "Healthcare", c => c.String());
            AddColumn("dbo.Metatags", "EcommerceRetail", c => c.String());
            AddColumn("dbo.Metatags", "WhatsappAuthentication", c => c.String());
            AddColumn("dbo.Metatags", "WhatsappSupport", c => c.String());
            AddColumn("dbo.Metatags", "WhatsappCommerce", c => c.String());
            AddColumn("dbo.Metatags", "WhatsAppMarketing", c => c.String());
            AddColumn("dbo.Metatags", "AppMarketing", c => c.String());
            AddColumn("dbo.Metatags", "AutoSegregation", c => c.String());
            AddColumn("dbo.Metatags", "ConversationalMarketing", c => c.String());
            AddColumn("dbo.Metatags", "AutomatedChatBot", c => c.String());
            AddColumn("dbo.Metatags", "ReportsAnalytics", c => c.String());
            AddColumn("dbo.Metatags", "WhatsAppBroadcasting", c => c.String());
            AddColumn("dbo.Metatags", "liveagentsupport", c => c.String());
            AddColumn("dbo.Metatags", "Index", c => c.String());
            DropColumn("dbo.Metatags", "KnowledgeCenterMeta");
            DropColumn("dbo.Metatags", "ContactUsMeta");
            DropColumn("dbo.Metatags", "BlogMeta");
            DropColumn("dbo.Metatags", "PartnerWithUsMeta");
            DropColumn("dbo.Metatags", "WorkWithUsMeta");
            DropColumn("dbo.Metatags", "AboutUsMeta");
            DropColumn("dbo.Metatags", "TravelHospitalityMeta");
            DropColumn("dbo.Metatags", "FoodBeverageMeta");
            DropColumn("dbo.Metatags", "MediaentertainmentMeta");
            DropColumn("dbo.Metatags", "BankingBFSIMeta");
            DropColumn("dbo.Metatags", "EdTechMeta");
            DropColumn("dbo.Metatags", "HealthcareMeta");
            DropColumn("dbo.Metatags", "EcommerceRetailMeta");
            DropColumn("dbo.Metatags", "WhatsappAuthenticationMeta");
            DropColumn("dbo.Metatags", "WhatsappSupportMeta");
            DropColumn("dbo.Metatags", "WhatsappCommerceMeta");
            DropColumn("dbo.Metatags", "WhatsAppMarketingMeta");
            DropColumn("dbo.Metatags", "AppMarketingMeta");
            DropColumn("dbo.Metatags", "AutoSegregationMeta");
            DropColumn("dbo.Metatags", "ConversationalMarketingMeta");
            DropColumn("dbo.Metatags", "AutomatedChatBotMeta");
            DropColumn("dbo.Metatags", "ReportsAnalyticsMeta");
            DropColumn("dbo.Metatags", "WhatsAppBroadcastingMeta");
            DropColumn("dbo.Metatags", "liveagentsupportMeta");
            DropColumn("dbo.Metatags", "IndexMeta");
        }
    }
}
