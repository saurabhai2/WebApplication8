namespace WebApplication8.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Changedatatype : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PatnerwithUs", "company", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PatnerwithUs", "company", c => c.Int(nullable: false));
        }
    }
}
