namespace ProMedi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aboutPhoto : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Abouts", "Photo", c => c.String(maxLength: 250));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Abouts", "Photo");
        }
    }
}
