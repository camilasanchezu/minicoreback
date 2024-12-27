using Microsoft.AspNetCore.Mvc;
using minicoreback.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace minicoreback.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GastosController : ControllerBase
    {
        private readonly IGastoService _gastoService;

        public GastosController(IGastoService gastoService)
        {
            _gastoService = gastoService;
        }

        [HttpGet("FiltrarPorFechas")]
        public async Task<IActionResult> FiltrarPorFechas([FromQuery] DateTime fechaInicio, [FromQuery] DateTime fechaFin)
        {
            if (fechaInicio > fechaFin)
            {
                return BadRequest("La fecha de inicio no puede ser mayor que la fecha de fin.");
            }

            var resultado = await _gastoService.ObtenerGastosPorDepartamentoAsync(fechaInicio, fechaFin);

            return Ok(resultado);
        }
    }
}
