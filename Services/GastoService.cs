using Microsoft.EntityFrameworkCore;
using minicoreback.DBContext;
using minicoreback.Interfaces;
using minicoreback.Models;

namespace minicoreback.Services
{
    public class GastoService: IGastoService
    {
        private readonly AppDbContext _context;

        public GastoService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<DepartamentoGastoDTO>> ObtenerGastosPorDepartamentoAsync(DateTime fechaInicio, DateTime fechaFin)
        {
            var gastos = await _context.Gastos
                .Include(g => g.Departamento) // Incluir los departamentos
                .Where(g => g.FechaGasto >= fechaInicio && g.FechaGasto <= fechaFin)
                .ToListAsync();

            var resultado = gastos
            .GroupBy(g => g.Departamento.NombreDepartamento)
                .Select(grupo => new DepartamentoGastoDTO
                {
                    Departamento = grupo.Key,
                    TotalGasto = grupo.Sum(g => g.MontoGasto)
                })
                .ToList();

            // Total general
            var totalGeneral = resultado.Sum(r => r.TotalGasto);
            resultado.Add(new DepartamentoGastoDTO
            {
                Departamento = "Total General",
                TotalGasto = totalGeneral
            });

            return resultado;
        }

    }
}
