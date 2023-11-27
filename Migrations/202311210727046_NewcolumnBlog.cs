namespace WebApplication8.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewcolumnBlog : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BlogPosts", "FeatureImagePath", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.BlogPosts", "FeatureImagePath");
        }
    }
}
