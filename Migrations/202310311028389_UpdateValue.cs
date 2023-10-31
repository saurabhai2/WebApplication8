namespace WebApplication8.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateValue : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tittles", "Index", c => c.String(nullable: false));
            AlterColumn("dbo.Tittles", "ReportsAnalytics", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tittles", "ReportsAnalytics", c => c.String());
            AlterColumn("dbo.Tittles", "Index", c => c.String());
        }
    }
}
