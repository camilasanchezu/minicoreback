using System.ComponentModel.DataAnnotations;

namespace minicoreback.Models
{
    public class Empleado
    {
        [Key]
        public int IdEmpleado { get; set; }
        public string NombreEmpleado { get; set; }
        public ICollection<Gasto> Gastos { get; set; } = new List<Gasto>();


    }
}
