namespace WebApplication8.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.KnowlageCentres", "CetegoryLine", c => c.String());
            DropColumn("dbo.BlogPosts", "TitleDescription");
            DropColumn("dbo.KnowlageCentres", "TitleDescription");
        }
        
        public override void Down()
        {
            AddColumn("dbo.KnowlageCentres", "TitleDescription", c => c.String());
            AddColumn("dbo.BlogPosts", "TitleDescription", c => c.String());
            DropColumn("dbo.KnowlageCentres", "CetegoryLine");
        }
    }
}
