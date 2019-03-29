namespace ProMedi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class blogDescLength : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Blogs", "Desc", c => c.String(maxLength: 1000));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Blogs", "Desc", c => c.String(maxLength: 150));
        }
    }
}
