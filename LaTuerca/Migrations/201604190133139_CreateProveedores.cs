namespace LaTuerca.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateProveedores : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Proveedors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RazonSocial = c.String(nullable: false, maxLength: 60),
                        Ruc = c.String(nullable: false, maxLength: 10),
                        Direccion = c.String(nullable: false),
                        Telefono = c.String(nullable: false),
                        Celular = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Proveedors");
        }
    }
}
