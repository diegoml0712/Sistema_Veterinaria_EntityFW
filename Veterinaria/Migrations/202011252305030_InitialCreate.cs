namespace Veterinaria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        RgUsuario = c.String(nullable: false, maxLength: 128),
                        IdUsuario = c.Int(nullable: false),
                        NomeComp = c.String(),
                        CPF = c.String(),
                        Telefone = c.String(),
                        Cep = c.String(),
                        UF = c.String(),
                        Cidade = c.String(),
                        Bairro = c.String(),
                        Rua = c.String(),
                        Numero = c.String(),
                        Complemento = c.String(),
                        Referencia = c.String(),
                    })
                .PrimaryKey(t => t.RgUsuario);
            
            CreateTable(
                "dbo.Pets",
                c => new
                    {
                        IdPet = c.Int(nullable: false, identity: true),
                        NomePet = c.String(),
                        Nascimento = c.DateTime(nullable: false),
                        RgUsuario = c.String(),
                        Especie = c.String(),
                        Raca = c.String(),
                        UltimaConsulta = c.DateTime(nullable: false),
                        ProximaConsulta = c.DateTime(nullable: false),
                        Historico = c.String(),
                        RgVet = c.String(),
                    })
                .PrimaryKey(t => t.IdPet);
            
            CreateTable(
                "dbo.SystemUsers",
                c => new
                    {
                        IdUsuario = c.Int(nullable: false, identity: true),
                        RgUsuario = c.String(),
                        NomeComp = c.String(),
                        senha = c.String(),
                        Cargo = c.String(),
                    })
                .PrimaryKey(t => t.IdUsuario);
            
            CreateTable(
                "dbo.Veterinarios",
                c => new
                    {
                        IdVeterinario = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        RG = c.String(),
                        Telefone = c.String(),
                        Especialidade = c.String(),
                    })
                .PrimaryKey(t => t.IdVeterinario);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Veterinarios");
            DropTable("dbo.SystemUsers");
            DropTable("dbo.Pets");
            DropTable("dbo.Clientes");
        }
    }
}
