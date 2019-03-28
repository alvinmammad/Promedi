namespace ProMedi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class smthng : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Appointments", "Photo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Appointments", "Photo", c => c.String(maxLength: 250));
        }
    }
}
