namespace LaTuerca.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRelationships1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Repuestoes", "Marca_Id", "dbo.Marcas");
            DropForeignKey("dbo.Repuestoes", "Proveedor_Id", "dbo.Proveedors");
            DropIndex("dbo.Repuestoes", new[] { "Marca_Id" });
            DropIndex("dbo.Repuestoes", new[] { "Proveedor_Id" });
            RenameColumn(table: "dbo.Repuestoes", name: "Marca_Id", newName: "MarcaId");
            RenameColumn(table: "dbo.Repuestoes", name: "Proveedor_Id", newName: "ProveedorId");
            AlterColumn("dbo.Repuestoes", "MarcaId", c => c.Int(nullable: false));
            AlterColumn("dbo.Repuestoes", "ProveedorId", c => c.Int(nullable: false));
            CreateIndex("dbo.Repuestoes", "ProveedorId");
            CreateIndex("dbo.Repuestoes", "MarcaId");
            AddForeignKey("dbo.Repuestoes", "MarcaId", "dbo.Marcas", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Repuestoes", "ProveedorId", "dbo.Proveedors", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Repuestoes", "ProveedorId", "dbo.Proveedors");
            DropForeignKey("dbo.Repuestoes", "MarcaId", "dbo.Marcas");
            DropIndex("dbo.Repuestoes", new[] { "MarcaId" });
            DropIndex("dbo.Repuestoes", new[] { "ProveedorId" });
            AlterColumn("dbo.Repuestoes", "ProveedorId", c => c.Int());
            AlterColumn("dbo.Repuestoes", "MarcaId", c => c.Int());
            RenameColumn(table: "dbo.Repuestoes", name: "ProveedorId", newName: "Proveedor_Id");
            RenameColumn(table: "dbo.Repuestoes", name: "MarcaId", newName: "Marca_Id");
            CreateIndex("dbo.Repuestoes", "Proveedor_Id");
            CreateIndex("dbo.Repuestoes", "Marca_Id");
            AddForeignKey("dbo.Repuestoes", "Proveedor_Id", "dbo.Proveedors", "Id");
            AddForeignKey("dbo.Repuestoes", "Marca_Id", "dbo.Marcas", "Id");
        }
    }
}
