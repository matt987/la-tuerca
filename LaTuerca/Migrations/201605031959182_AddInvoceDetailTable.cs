namespace LaTuerca.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddInvoceDetailTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.InvoiceDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cantidad = c.Int(nullable: false),
                        Precio = c.Single(nullable: false),
                        InvoiceId = c.Int(nullable: false),
                        RepuestoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Invoices", t => t.InvoiceId, cascadeDelete: true)
                .ForeignKey("dbo.Repuestoes", t => t.RepuestoId, cascadeDelete: true)
                .Index(t => t.InvoiceId)
                .Index(t => t.RepuestoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.InvoiceDetails", "RepuestoId", "dbo.Repuestoes");
            DropForeignKey("dbo.InvoiceDetails", "InvoiceId", "dbo.Invoices");
            DropIndex("dbo.InvoiceDetails", new[] { "RepuestoId" });
            DropIndex("dbo.InvoiceDetails", new[] { "InvoiceId" });
            DropTable("dbo.InvoiceDetails");
        }
    }
}
