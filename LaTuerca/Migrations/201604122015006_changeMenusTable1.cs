namespace LaTuerca.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeMenusTable1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Menus", "Action", c => c.String(nullable: false));
            AddColumn("dbo.Menus", "Controller", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Menus", "Controller");
            DropColumn("dbo.Menus", "Action");
        }
    }
}
