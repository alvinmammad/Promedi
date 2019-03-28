namespace ProMedi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class departmentChanged : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Departments", "HeadType", c => c.String());
            AddColumn("dbo.Departments", "HeadDoctor", c => c.String());
            AlterColumn("dbo.Departments", "EventHours", c => c.String());
            DropColumn("dbo.Departments", "Head");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Departments", "Head", c => c.String());
            AlterColumn("dbo.Departments", "EventHours", c => c.Int(nullable: false));
            DropColumn("dbo.Departments", "HeadDoctor");
            DropColumn("dbo.Departments", "HeadType");
        }
    }
}
