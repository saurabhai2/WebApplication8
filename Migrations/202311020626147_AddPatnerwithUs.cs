namespace WebApplication8.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPatnerwithUs : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PatnerwithUs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        Name = c.String(),
                        Phone = c.String(),
                        Designation = c.String(),
                        country = c.String(),
                        company = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PatnerwithUs");
        }
    }
}
