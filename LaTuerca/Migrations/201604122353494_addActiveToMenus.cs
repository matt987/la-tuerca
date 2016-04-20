namespace LaTuerca.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addActiveToMenus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Menus", "Active", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Menus", "Active");
        }
    }
}
