namespace ProMedi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class datedeleted : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Appointments", "Date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Appointments", "Date", c => c.DateTime(nullable: false));
        }
    }
}
