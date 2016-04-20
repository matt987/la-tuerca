namespace LaTuerca.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeMenusTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Menus", "Parent_Id", "dbo.Menus");
            DropIndex("dbo.Menus", new[] { "Parent_Id" });
            AddColumn("dbo.Menus", "ParentId", c => c.Int(nullable: false));
            AlterColumn("dbo.Menus", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Menus", "Description", c => c.String(nullable: false));
            DropColumn("dbo.Menus", "Parent_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Menus", "Parent_Id", c => c.Int());
            AlterColumn("dbo.Menus", "Description", c => c.Int(nullable: false));
            AlterColumn("dbo.Menus", "Name", c => c.Int(nullable: false));
            DropColumn("dbo.Menus", "ParentId");
            CreateIndex("dbo.Menus", "Parent_Id");
            AddForeignKey("dbo.Menus", "Parent_Id", "dbo.Menus", "Id");
        }
    }
}
