namespace WebApplication8.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Adddtablesss : DbMigration
    {
        public override void Up()
        {
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MetatagChecks");
        }
    }
}
