namespace WebApplication8.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addblogtable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BlogPosts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Category = c.String(nullable: false),
                        Meta = c.String(nullable: false),
                        Schema = c.String(nullable: false),
                        datePublish = c.String(),
                        author = c.String(nullable: false),
                        MainHeading = c.String(nullable: false),
                        Content = c.String(nullable: false),
                        SlugUrl = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BlogPosts");
        }
    }
}
