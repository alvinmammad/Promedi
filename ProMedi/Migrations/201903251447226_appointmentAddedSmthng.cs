namespace ProMedi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class appointmentAddedSmthng : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Appointments", "Name", c => c.String());
            AddColumn("dbo.Appointments", "Mail", c => c.String());
            AddColumn("dbo.Appointments", "Date", c => c.DateTime(nullable: false));
            AddColumn("dbo.Appointments", "Message", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Appointments", "Message");
            DropColumn("dbo.Appointments", "Date");
            DropColumn("dbo.Appointments", "Mail");
            DropColumn("dbo.Appointments", "Name");
        }
    }
}
