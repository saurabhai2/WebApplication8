namespace WebApplication8.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Dropdb1 : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.AdminTittle");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.AdminTittles",
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
                        whatsappbusinessappvswhatsappbusinessapi = c.String(),
                        whatsappmarketingstrategiestodrivesales = c.String(),
                        reshapingcustomerengagementonwhatsapp = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
