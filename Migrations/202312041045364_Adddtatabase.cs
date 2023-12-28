namespace WebApplication8.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Adddtatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BlogPosts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        TitleDescription = c.String(),
                        Category = c.String(),
                        Meta = c.String(),
                        Schema = c.String(),
                        datePublish = c.String(),
                        author = c.String(),
                        MainHeading = c.String(),
                        FeatureImagePath = c.String(),
                        Content = c.String(),
                        SlugUrl = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.KnowlageCentres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        TitleDescription = c.String(),
                        Category = c.String(nullable: false),
                        Meta = c.String(nullable: false),
                        Schema = c.String(nullable: false),
                        datePublish = c.String(),
                        author = c.String(nullable: false),
                        MainHeading = c.String(nullable: false),
                        Content = c.String(nullable: false),
                        SlugUrl = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Metatags",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IndexMeta = c.String(),
                        liveagentsupportMeta = c.String(),
                        WhatsAppBroadcastingMeta = c.String(),
                        ReportsAnalyticsMeta = c.String(),
                        AutomatedChatBotMeta = c.String(),
                        ConversationalMarketingMeta = c.String(),
                        AutoSegregationMeta = c.String(),
                        AppMarketingMeta = c.String(),
                        WhatsAppMarketingMeta = c.String(),
                        WhatsappCommerceMeta = c.String(),
                        WhatsappSupportMeta = c.String(),
                        WhatsappAuthenticationMeta = c.String(),
                        EcommerceRetailMeta = c.String(),
                        HealthcareMeta = c.String(),
                        EdTechMeta = c.String(),
                        BankingBFSIMeta = c.String(),
                        MediaentertainmentMeta = c.String(),
                        FoodBeverageMeta = c.String(),
                        TravelHospitalityMeta = c.String(),
                        AboutUsMeta = c.String(),
                        WorkWithUsMeta = c.String(),
                        PartnerWithUsMeta = c.String(),
                        BlogMeta = c.String(),
                        ContactUsMeta = c.String(),
                        KnowledgeCenterMeta = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MetatagChecks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IndexMeta = c.Boolean(nullable: false),
                        liveagentsupportMeta = c.Boolean(nullable: false),
                        WhatsAppBroadcastingMeta = c.Boolean(nullable: false),
                        ReportsAnalyticsMeta = c.Boolean(nullable: false),
                        AutomatedChatBotMeta = c.Boolean(nullable: false),
                        ConversationalMarketingMeta = c.Boolean(nullable: false),
                        AutoSegregationMeta = c.Boolean(nullable: false),
                        AppMarketingMeta = c.Boolean(nullable: false),
                        WhatsAppMarketingMeta = c.Boolean(nullable: false),
                        WhatsappCommerceMeta = c.Boolean(nullable: false),
                        WhatsappSupportMeta = c.Boolean(nullable: false),
                        WhatsappAuthenticationMeta = c.Boolean(nullable: false),
                        EcommerceRetailMeta = c.Boolean(nullable: false),
                        HealthcareMeta = c.Boolean(nullable: false),
                        EdTechMeta = c.Boolean(nullable: false),
                        BankingBFSIMeta = c.Boolean(nullable: false),
                        MediaentertainmentMeta = c.Boolean(nullable: false),
                        FoodBeverageMeta = c.Boolean(nullable: false),
                        TravelHospitalityMeta = c.Boolean(nullable: false),
                        AboutUsMeta = c.Boolean(nullable: false),
                        WorkWithUsMeta = c.Boolean(nullable: false),
                        PartnerWithUsMeta = c.Boolean(nullable: false),
                        BlogMeta = c.Boolean(nullable: false),
                        ContactUsMeta = c.Boolean(nullable: false),
                        KnowledgeCenterMeta = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MetatagSchemas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IndexMeta = c.String(),
                        liveagentsupportMeta = c.String(),
                        WhatsAppBroadcastingMeta = c.String(),
                        ReportsAnalyticsMeta = c.String(),
                        AutomatedChatBotMeta = c.String(),
                        ConversationalMarketingMeta = c.String(),
                        AutoSegregationMeta = c.String(),
                        AppMarketingMeta = c.String(),
                        WhatsAppMarketingMeta = c.String(),
                        WhatsappCommerceMeta = c.String(),
                        WhatsappSupportMeta = c.String(),
                        WhatsappAuthenticationMeta = c.String(),
                        EcommerceRetailMeta = c.String(),
                        HealthcareMeta = c.String(),
                        EdTechMeta = c.String(),
                        BankingBFSIMeta = c.String(),
                        MediaentertainmentMeta = c.String(),
                        FoodBeverageMeta = c.String(),
                        TravelHospitalityMeta = c.String(),
                        AboutUsMeta = c.String(),
                        WorkWithUsMeta = c.String(),
                        PartnerWithUsMeta = c.String(),
                        BlogMeta = c.String(),
                        ContactUsMeta = c.String(),
                        KnowledgeCenterMeta = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MetatagSchemas");
            DropTable("dbo.MetatagChecks");
            DropTable("dbo.Metatags");
            DropTable("dbo.KnowlageCentres");
            DropTable("dbo.BlogPosts");
        }
    }
}
