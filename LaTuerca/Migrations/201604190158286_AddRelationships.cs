namespace LaTuerca.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRelationships : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Repuestoes", "Marca_Id", c => c.Int());
            AddColumn("dbo.Repuestoes", "Proveedor_Id", c => c.Int());
            CreateIndex("dbo.Repuestoes", "Marca_Id");
            CreateIndex("dbo.Repuestoes", "Proveedor_Id");
            AddForeignKey("dbo.Repuestoes", "Marca_Id", "dbo.Marcas", "Id");
            AddForeignKey("dbo.Repuestoes", "Proveedor_Id", "dbo.Proveedors", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Repuestoes", "Proveedor_Id", "dbo.Proveedors");
            DropForeignKey("dbo.Repuestoes", "Marca_Id", "dbo.Marcas");
            DropIndex("dbo.Repuestoes", new[] { "Proveedor_Id" });
            DropIndex("dbo.Repuestoes", new[] { "Marca_Id" });
            DropColumn("dbo.Repuestoes", "Proveedor_Id");
            DropColumn("dbo.Repuestoes", "Marca_Id");
        }
    }
}
