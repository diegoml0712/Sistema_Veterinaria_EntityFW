namespace Veterinaria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class banco1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Clientes", "IdUsuario");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clientes", "IdUsuario", c => c.Int(nullable: false));
        }
    }
}
