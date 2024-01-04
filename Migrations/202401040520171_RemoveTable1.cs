namespace WebApplication8.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveTable1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ContactForms", "RefNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ContactForms", "RefNumber", c => c.String());
        }
    }
}
