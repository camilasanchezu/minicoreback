using System.ComponentModel.DataAnnotations;

namespace minicoreback.Models
{
    public class Departamento
    {
        [Key]
        public int IdDepartamento { get; set; }
        public string NombreDepartamento { get; set; }

        public ICollection<Gasto> Gastos { get; set; } = new List<Gasto>();
    }
}
