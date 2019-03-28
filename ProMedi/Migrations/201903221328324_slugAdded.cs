namespace ProMedi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class slugAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blogs", "Slug", c => c.String(maxLength: 1000));
            AddColumn("dbo.Services", "Slug", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Services", "Slug");
            DropColumn("dbo.Blogs", "Slug");
        }
    }
}
