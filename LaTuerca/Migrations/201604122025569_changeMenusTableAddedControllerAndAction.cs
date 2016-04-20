namespace LaTuerca.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeMenusTableAddedControllerAndAction : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Menus", "Action", c => c.String());
            AlterColumn("dbo.Menus", "Controller", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Menus", "Controller", c => c.String(nullable: false));
            AlterColumn("dbo.Menus", "Action", c => c.String(nullable: false));
        }
    }
}
