namespace ProMedi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dp : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Doctors", "DepartmentID", "dbo.Departments");
            DropIndex("dbo.Doctors", new[] { "DepartmentID" });
            DropColumn("dbo.Departments", "DoctorID");
            DropColumn("dbo.Doctors", "DepartmentID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Doctors", "DepartmentID", c => c.Int(nullable: false));
            AddColumn("dbo.Departments", "DoctorID", c => c.Int(nullable: false));
            CreateIndex("dbo.Doctors", "DepartmentID");
            AddForeignKey("dbo.Doctors", "DepartmentID", "dbo.Departments", "ID", cascadeDelete: true);
        }
    }
}
