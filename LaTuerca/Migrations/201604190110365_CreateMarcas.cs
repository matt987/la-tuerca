namespace LaTuerca.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateMarcas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Marcas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 60),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Marcas");
        }
    }
}
