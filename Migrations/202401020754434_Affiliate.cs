namespace WebApplication8.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Affiliate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Affiliates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        email = c.String(),
                        phone = c.String(),
                        country = c.String(),
                        company = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Affiliates");
        }
    }
}
