namespace VD191672_MM191627Taller1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Empleadoes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Codigo = c.String(),
                        Nombres = c.String(),
                        Apellidos = c.String(),
                        FechaNacimiento = c.String(),
                        Direccion = c.String(),
                        Telefono = c.String(),
                        Cargo = c.String(),
                        SueldoBase = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AñosLaborales = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Empleadoes");
        }
    }
}
