namespace ProMedi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sliderDeleted : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Sliders");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Sliders",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Photo = c.String(maxLength: 250),
                        Desc = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.ID);
            
        }
    }
}
