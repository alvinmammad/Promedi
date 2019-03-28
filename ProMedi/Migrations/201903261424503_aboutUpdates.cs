namespace ProMedi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aboutUpdates : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AboutBodies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Desc = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.AboutFeatures",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            DropColumn("dbo.Abouts", "Icon");
            DropColumn("dbo.Abouts", "Help");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Abouts", "Help", c => c.String());
            AddColumn("dbo.Abouts", "Icon", c => c.String(maxLength: 250));
            DropTable("dbo.AboutFeatures");
            DropTable("dbo.AboutBodies");
        }
    }
}
