namespace ProMedi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class contactUpdated : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Contacts", "Opening");
            DropColumn("dbo.Contacts", "Closing");
            DropColumn("dbo.Contacts", "Lattitude");
            DropColumn("dbo.Contacts", "Longitude");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Contacts", "Longitude", c => c.String(maxLength: 100));
            AddColumn("dbo.Contacts", "Lattitude", c => c.String(maxLength: 100));
            AddColumn("dbo.Contacts", "Closing", c => c.DateTime(nullable: false));
            AddColumn("dbo.Contacts", "Opening", c => c.DateTime(nullable: false));
        }
    }
}
