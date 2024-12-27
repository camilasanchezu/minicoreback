using minicoreback.Models;

namespace minicoreback.Interfaces
{
    public interface IGastoService
    {
        Task<IEnumerable<DepartamentoGastoDTO>> ObtenerGastosPorDepartamentoAsync(DateTime fechaInicio, DateTime fechaFin);
    }
}
