namespace ProMedi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class card : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cards",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Desc = c.String(),
                        Icon = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Abouts", "Icon", c => c.String(maxLength: 250));
            AddColumn("dbo.Abouts", "Help", c => c.String());
            AddColumn("dbo.Departments", "Head", c => c.String());
            DropColumn("dbo.Abouts", "Photo");
            DropColumn("dbo.Settings", "AboutTitle");
            DropColumn("dbo.Settings", "AboutDesc");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Settings", "AboutDesc", c => c.String(maxLength: 150));
            AddColumn("dbo.Settings", "AboutTitle", c => c.String(maxLength: 35));
            AddColumn("dbo.Abouts", "Photo", c => c.String(maxLength: 250));
            DropColumn("dbo.Departments", "Head");
            DropColumn("dbo.Abouts", "Help");
            DropColumn("dbo.Abouts", "Icon");
            DropTable("dbo.Cards");
        }
    }
}
