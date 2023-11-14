namespace WebApplication8.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSchemaTable : DbMigration
    {
        public override void Up()
        {
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
        }
    }
}
