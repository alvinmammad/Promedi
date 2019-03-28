namespace ProMedi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bossAdded : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Admins", newName: "Bosses");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Bosses", newName: "Admins");
        }
    }
}
