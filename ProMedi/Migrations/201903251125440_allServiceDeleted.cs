namespace ProMedi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class allServiceDeleted : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Services");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Logo = c.String(maxLength: 250),
                        Name = c.String(maxLength: 20),
                        Title = c.String(maxLength: 55),
                        Slug = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
        }
    }
}
