namespace LaTuerca.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCelularToClientes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "Celular", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clientes", "Celular");
        }
    }
}
