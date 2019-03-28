namespace ProMedi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Abouts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 20),
                        Desc = c.String(maxLength: 150),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Photo = c.String(maxLength: 250),
                        Phone = c.String(maxLength: 20),
                        DoctorID = c.Int(nullable: false),
                        DepartmentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Departments", t => t.DepartmentID, cascadeDelete: true)
                .ForeignKey("dbo.Doctors", t => t.DoctorID, cascadeDelete: true)
                .Index(t => t.DoctorID)
                .Index(t => t.DepartmentID);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        EventHours = c.Int(nullable: false),
                        Name = c.String(maxLength: 30),
                        Title = c.String(maxLength: 40),
                        Desc = c.String(maxLength: 200),
                        EventType = c.String(maxLength: 30),
                        Address = c.String(maxLength: 50),
                        Email = c.String(maxLength: 30),
                        Phone = c.String(maxLength: 20),
                        Photo = c.String(maxLength: 250),
                        Icon = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 35),
                        Desc = c.String(maxLength: 150),
                        Photo = c.String(maxLength: 250),
                        Info = c.String(maxLength: 70),
                        Address = c.String(maxLength: 35),
                        Phone = c.String(maxLength: 20),
                        Email = c.String(maxLength: 25),
                        Speciality = c.String(maxLength: 35),
                        Degree = c.String(maxLength: 35),
                        ExpertIn = c.String(maxLength: 40),
                        CategoryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.DoctorCategories", t => t.CategoryID, cascadeDelete: true)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.DoctorCategories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Blogs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 45),
                        Desc = c.String(maxLength: 150),
                        Photo = c.String(maxLength: 250),
                        Blockquote = c.String(maxLength: 200),
                        Date = c.DateTime(nullable: false),
                        Comment = c.Int(nullable: false),
                        CategoryID = c.Int(nullable: false),
                        AuthorID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Authors", t => t.AuthorID, cascadeDelete: true)
                .ForeignKey("dbo.Categories", t => t.CategoryID, cascadeDelete: true)
                .Index(t => t.CategoryID)
                .Index(t => t.AuthorID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Email = c.String(maxLength: 30),
                        Opening = c.DateTime(nullable: false),
                        Closing = c.DateTime(nullable: false),
                        Lattitude = c.String(maxLength: 100),
                        Longitude = c.String(maxLength: 100),
                        Title = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Facts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        OrderBy = c.Int(nullable: false),
                        Value = c.Int(nullable: false),
                        Key = c.String(maxLength: 20),
                        Icon = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Features",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Logo = c.String(maxLength: 250),
                        Name = c.String(maxLength: 25),
                        Title = c.String(maxLength: 55),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.HomeCards",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Photo = c.String(maxLength: 250),
                        Name = c.String(maxLength: 20),
                        Title = c.String(maxLength: 55),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.HomeExperiences",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Desc = c.String(maxLength: 150),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Logo = c.String(maxLength: 250),
                        Name = c.String(maxLength: 20),
                        Title = c.String(maxLength: 55),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Settings",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Phone = c.String(maxLength: 20),
                        Location = c.String(maxLength: 35),
                        AboutTitle = c.String(maxLength: 35),
                        AboutDesc = c.String(maxLength: 150),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 35),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Blogs", "CategoryID", "dbo.Categories");
            DropForeignKey("dbo.Blogs", "AuthorID", "dbo.Authors");
            DropForeignKey("dbo.Doctors", "CategoryID", "dbo.DoctorCategories");
            DropForeignKey("dbo.Appointments", "DoctorID", "dbo.Doctors");
            DropForeignKey("dbo.Appointments", "DepartmentID", "dbo.Departments");
            DropIndex("dbo.Blogs", new[] { "AuthorID" });
            DropIndex("dbo.Blogs", new[] { "CategoryID" });
            DropIndex("dbo.Doctors", new[] { "CategoryID" });
            DropIndex("dbo.Appointments", new[] { "DepartmentID" });
            DropIndex("dbo.Appointments", new[] { "DoctorID" });
            DropTable("dbo.Tags");
            DropTable("dbo.Settings");
            DropTable("dbo.Services");
            DropTable("dbo.HomeExperiences");
            DropTable("dbo.HomeCards");
            DropTable("dbo.Features");
            DropTable("dbo.Facts");
            DropTable("dbo.Contacts");
            DropTable("dbo.Categories");
            DropTable("dbo.Blogs");
            DropTable("dbo.Authors");
            DropTable("dbo.DoctorCategories");
            DropTable("dbo.Doctors");
            DropTable("dbo.Departments");
            DropTable("dbo.Appointments");
            DropTable("dbo.Abouts");
        }
    }
}
