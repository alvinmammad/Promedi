namespace ProMedi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class authorPhoto : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Authors", "Photo", c => c.String(maxLength: 250));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Authors", "Photo");
        }
    }
}
