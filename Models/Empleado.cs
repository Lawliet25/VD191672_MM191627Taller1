using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace VD191672_MM191627Taller1.Models
{
    public class Empleado
    {
        public int ID { get; set; }
        [Required]
        [RegularExpression(@"^EMP\d{3}$", ErrorMessage = "El campo Codigo debe tener el formato EMP seguido de tres números.")]
        public string Codigo { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Nombres { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Apellidos { get; set; }
        
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaNacimiento { get; set; }
        public string Direccion { get; set; }

        [RegularExpression(@"^\d{4}-\d{4}$", ErrorMessage = "El número de teléfono debe tener el formato 1234-5678")]
        public string Telefono { get; set; }
        [Required]
        public string Cargo { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public decimal SueldoBase { get; set; }
        [Required]
        [RegularExpression("^[0-9]+$")]
        public int? AñosLaborales { get; set; }
    }
    public class EmpleadoDBContext : DbContext
    {
        public DbSet<Empleado> Empleados { get; set; }
    }
}