namespace WebApplication8.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Validation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tittles", "Index", c => c.String());
            AlterColumn("dbo.Tittles", "liveagentsupport", c => c.String());
            AlterColumn("dbo.Tittles", "WhatsAppBroadcasting", c => c.String());
            AlterColumn("dbo.Tittles", "ReportsAnalytics", c => c.String());
            AlterColumn("dbo.Tittles", "ConversationalMarketing", c => c.String());
            AlterColumn("dbo.Tittles", "AutoSegregation", c => c.String());
            AlterColumn("dbo.Tittles", "WhatsAppMarketing", c => c.String());
            AlterColumn("dbo.Tittles", "WhatsappSupport", c => c.String());
            AlterColumn("dbo.Tittles", "WhatsappAuthentication", c => c.String());
            AlterColumn("dbo.Tittles", "Healthcare", c => c.String());
            AlterColumn("dbo.Tittles", "EdTech", c => c.String());
            AlterColumn("dbo.Tittles", "Mediaentertainment", c => c.String());
            AlterColumn("dbo.Tittles", "FoodBeverage", c => c.String());
            AlterColumn("dbo.Tittles", "AboutUs", c => c.String());
            AlterColumn("dbo.Tittles", "WorkWithUs", c => c.String());
            AlterColumn("dbo.Tittles", "Blog", c => c.String());
            AlterColumn("dbo.Tittles", "ContactUs", c => c.String());
            AlterColumn("dbo.Tittles", "whatsappbusinessappvswhatsappbusinessapi", c => c.String());
            AlterColumn("dbo.Tittles", "whatsappmarketingstrategiestodrivesales", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tittles", "whatsappmarketingstrategiestodrivesales", c => c.String(nullable: false));
            AlterColumn("dbo.Tittles", "whatsappbusinessappvswhatsappbusinessapi", c => c.String(nullable: false));
            AlterColumn("dbo.Tittles", "ContactUs", c => c.String(nullable: false));
            AlterColumn("dbo.Tittles", "Blog", c => c.String(nullable: false));
            AlterColumn("dbo.Tittles", "WorkWithUs", c => c.String(nullable: false));
            AlterColumn("dbo.Tittles", "AboutUs", c => c.String(nullable: false));
            AlterColumn("dbo.Tittles", "FoodBeverage", c => c.String(nullable: false));
            AlterColumn("dbo.Tittles", "Mediaentertainment", c => c.String(nullable: false));
            AlterColumn("dbo.Tittles", "EdTech", c => c.String(nullable: false));
            AlterColumn("dbo.Tittles", "Healthcare", c => c.String(nullable: false));
            AlterColumn("dbo.Tittles", "WhatsappAuthentication", c => c.String(nullable: false));
            AlterColumn("dbo.Tittles", "WhatsappSupport", c => c.String(nullable: false));
            AlterColumn("dbo.Tittles", "WhatsAppMarketing", c => c.String(nullable: false));
            AlterColumn("dbo.Tittles", "AutoSegregation", c => c.String(nullable: false));
            AlterColumn("dbo.Tittles", "ConversationalMarketing", c => c.String(nullable: false));
            AlterColumn("dbo.Tittles", "ReportsAnalytics", c => c.String(nullable: false));
            AlterColumn("dbo.Tittles", "WhatsAppBroadcasting", c => c.String(nullable: false));
            AlterColumn("dbo.Tittles", "liveagentsupport", c => c.String(nullable: false));
            AlterColumn("dbo.Tittles", "Index", c => c.String(nullable: false));
        }
    }
}
