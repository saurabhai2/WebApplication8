namespace WebApplication8.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddtableAffiliate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Affiliates", "Affiliates", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Affiliates", "Affiliates");
        }
    }
}
