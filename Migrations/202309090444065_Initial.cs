namespace VD191672_MM191627Taller1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Empleadoes", "FechaNacimiento", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Empleadoes", "FechaNacimiento", c => c.String());
        }
    }
}
