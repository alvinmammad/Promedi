namespace ProMedi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class departmentDoctorAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Departments", "DoctorID", c => c.Int(nullable: false));
            AddColumn("dbo.Doctors", "DepartmentID", c => c.Int(nullable: false));
            CreateIndex("dbo.Doctors", "DepartmentID");
            AddForeignKey("dbo.Doctors", "DepartmentID", "dbo.Departments", "ID", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Doctors", "DepartmentID", "dbo.Departments");
            DropIndex("dbo.Doctors", new[] { "DepartmentID" });
            DropColumn("dbo.Doctors", "DepartmentID");
            DropColumn("dbo.Departments", "DoctorID");
        }
    }
}
