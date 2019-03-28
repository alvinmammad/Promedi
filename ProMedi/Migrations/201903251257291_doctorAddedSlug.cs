namespace ProMedi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class doctorAddedSlug : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Doctors", "Slug", c => c.String(maxLength: 1000));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Doctors", "Slug");
        }
    }
}
