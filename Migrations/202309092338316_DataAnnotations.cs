namespace VD191672_MM191627Taller1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Empleadoes", "Codigo", c => c.String(nullable: false));
            AlterColumn("dbo.Empleadoes", "Nombres", c => c.String(nullable: false, maxLength: 60));
            AlterColumn("dbo.Empleadoes", "Apellidos", c => c.String(nullable: false, maxLength: 60));
            AlterColumn("dbo.Empleadoes", "Cargo", c => c.String(nullable: false));
            AlterColumn("dbo.Empleadoes", "AñosLaborales", c => c.Int(nullable: false));
            DropColumn("dbo.Empleadoes", "Bono");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Empleadoes", "Bono", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Empleadoes", "AñosLaborales", c => c.Int());
            AlterColumn("dbo.Empleadoes", "Cargo", c => c.String());
            AlterColumn("dbo.Empleadoes", "Apellidos", c => c.String());
            AlterColumn("dbo.Empleadoes", "Nombres", c => c.String());
            AlterColumn("dbo.Empleadoes", "Codigo", c => c.String());
        }
    }
}
