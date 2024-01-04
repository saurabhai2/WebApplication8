namespace WebApplication8.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUSerAffiliate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AffiliateUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        User = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AffiliateUsers");
        }
    }
}
