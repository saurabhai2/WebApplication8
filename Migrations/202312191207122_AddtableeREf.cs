namespace WebApplication8.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddtableeREf : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ContactForms", "RefNumber", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ContactForms", "RefNumber");
        }
    }
}
