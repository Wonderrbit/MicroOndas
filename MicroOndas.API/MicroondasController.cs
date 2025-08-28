using Microsoft.AspNetCore.Mvc;
using MicroOndas.Business;

namespace MicroOndas.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MicroondasController : ControllerBase
    {
        private static Microondas _micro = new Microondas();

        [HttpPost("configurar")]
        public IActionResult Configurar(int tempo, int potencia = 10)
        {
            try
            {
                _micro.Configurar(tempo, potencia);
                return Ok(new { mensagem = "Configuração aplicada", tempo = _micro.Tempo, potencia = _micro.Potencia });
            }
            catch (Exception ex)
            {
                return BadRequest(new { erro = ex.Message });
            }
        }

        [HttpPost("iniciar")]
        public IActionResult Iniciar()
        {
            _micro.Iniciar();
            return Ok(new { estado = _micro.Estado.ToString(), tempo = _micro.Tempo, potencia = _micro.Potencia });
        }

        [HttpPost("pausar-cancelar")]
        public IActionResult PausarOuCancelar()
        {
            _micro.PausarOuCancelar();
            return Ok(new { estado = _micro.Estado.ToString(), tempo = _micro.Tempo });
        }

        [HttpPost("acrescentar")]
        public IActionResult AcrescentarTempo()
        {
            _micro.AcrescentarTempo();
            return Ok(new { tempo = _micro.Tempo });
        }
    }
}
