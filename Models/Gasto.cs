
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace minicoreback.Models
{
    public class Gasto
    {
        [Key]
        public int IdGasto { get; set; }
        public string DescripcionGasto { get; set; }
        public DateTime FechaGasto { get; set; }
        public decimal MontoGasto { get; set; }

        public int IdEmpleado { get; set; }
        [ForeignKey("IdEmpleado")]
        
        public Empleado Empleado { get; set; } = null!;

        public int IdDepartamento { get; set; }
        [ForeignKey("IdDepartamento")]
        public Departamento Departamento { get; set; } = null!;

    }
}
