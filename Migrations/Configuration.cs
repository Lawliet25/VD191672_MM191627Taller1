namespace VD191672_MM191627Taller1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using VD191672_MM191627Taller1.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<VD191672_MM191627Taller1.Models.EmpleadoDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "VD191672_MM191627Taller1.Models.EmpleadoDBContext";
        }

        protected override void Seed(VD191672_MM191627Taller1.Models.EmpleadoDBContext context)
        {
            context.Empleados.AddOrUpdate(i => i.Codigo,
            new Empleado
            {
                Codigo = "EMP001",
                Nombres = "Daniel Alejandro",
                Apellidos = "Molina Menjívar",
                FechaNacimiento = DateTime.Parse("2011-3-15"),
                Direccion = "Apopa",
                Telefono = "2222-2222",
                Cargo = "Ingeniero",
                SueldoBase = 1000.00M,
                AñosLaborales = 5
            },
            new Empleado
            {
                Codigo = "EMP002",
                Nombres = "Rodrigo Fernando",
                Apellidos = "Valle Díaz",
                FechaNacimiento = DateTime.Parse("2011-3-15"),
                Direccion = "Apopa",
                Telefono = "2222-2222",
                Cargo = "Ingeniero",
                SueldoBase = 1000.00M,
                AñosLaborales = 3
            },
            new Empleado
            {
                Codigo = "EMP003",
                Nombres = "Oscar Alejandro",
                Apellidos = "Linares López",
                FechaNacimiento = DateTime.Parse("2011-3-15"),
                Direccion = "Apopa",
                Telefono = "2222-2222",
                Cargo = "Ingeniero",
                SueldoBase = 1000.00M,
                AñosLaborales = 5
            },
            new Empleado
            {
                Codigo = "EMP004",
                Nombres = "Josseline Melissa",
                Apellidos = "Recinos Rodríguez",
                FechaNacimiento = DateTime.Parse("2011-3-15"),
                Direccion = "Apopa",
                Telefono = "2222-2222",
                Cargo = "Ingeniero",
                SueldoBase = 1000.00M,
                AñosLaborales = 6
            },
            new Empleado
            {
                Codigo = "EMP005",
                Nombres = "Henry Francisco",
                Apellidos = "Ventura Rosales",
                FechaNacimiento = DateTime.Parse("2011-3-15"),
                Direccion = "Apopa",
                Telefono = "2222-2222",
                Cargo = "Ingeniero",
                SueldoBase = 1000.00M,
                AñosLaborales = 8 
            }
          );
        }
    }
}
