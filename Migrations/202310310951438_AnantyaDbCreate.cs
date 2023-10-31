namespace WebApplication8.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AnantyaDbCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Registers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Email = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tittles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Index = c.String(),
                        liveagentsupport = c.String(nullable: false),
                        WhatsAppBroadcasting = c.String(nullable: false),
                        ReportsAnalytics = c.String(),
                        AutomatedChatBot = c.String(),
                        ConversationalMarketing = c.String(nullable: false),
                        AutoSegregation = c.String(nullable: false),
                        AppMarketing = c.String(),
                        WhatsAppMarketing = c.String(nullable: false),
                        WhatsappCommerce = c.String(),
                        WhatsappSupport = c.String(nullable: false),
                        WhatsappAuthentication = c.String(nullable: false),
                        EcommerceRetail = c.String(),
                        Healthcare = c.String(nullable: false),
                        EdTech = c.String(nullable: false),
                        BankingBFSI = c.String(),
                        Mediaentertainment = c.String(nullable: false),
                        FoodBeverage = c.String(nullable: false),
                        TravelHospitality = c.String(),
                        AboutUs = c.String(nullable: false),
                        WorkWithUs = c.String(nullable: false),
                        PartnerWithUs = c.String(),
                        Blog = c.String(nullable: false),
                        ContactUs = c.String(nullable: false),
                        KnowledgeCenter = c.String(),
                        whatsappbusinessappvswhatsappbusinessapi = c.String(nullable: false),
                        whatsappmarketingstrategiestodrivesales = c.String(nullable: false),
                        reshapingcustomerengagementonwhatsapp = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tittles");
            DropTable("dbo.Registers");
        }
    }
}
