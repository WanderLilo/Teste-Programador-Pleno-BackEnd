using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using tarefa_2.ApplicationCore.DTOs;
using tarefa_2.ApplicationCore.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace tarefa_2.API.Controllers
{
    [Route("api/cidade")]
    [ApiController]
    public class CidadeController : ControllerBase
    {
        private readonly INotificador _notificador;
        private readonly ICidadeService _cidadeService;

        public CidadeController(INotificador notificador, ICidadeService cidadeService)
        {
            _notificador = notificador;
            _cidadeService = cidadeService;
        }


        [HttpGet("consulta-por-estado/{siglaEstado}")]
        [ProducesResponseType(typeof(List<CidadeDTO>) , StatusCodes.Status200OK)]
        public async Task<ActionResult<List<CidadeDTO>>> ObterPorEstado([FromRoute] string siglaEstado)
        {
            var response = await _cidadeService.ObterPorEstadoAsync(siglaEstado);
            return Ok(response);
        }


        [HttpGet("consulta-por-estado-paginada/{siglaEstado}")]
        [ProducesResponseType(typeof(List<CidadeDTO>), StatusCodes.Status200OK)]
        public async Task<ActionResult<List<CidadeDTO>>> ObterPorEstadoPaginada([FromRoute] string siglaEstado, [FromQuery] int skip=0, [FromQuery] int take=50)
        {
            var response = await _cidadeService.ObterPorEstadoPaginadaAsync(siglaEstado,skip,take);
            return Ok(response);
        }


        // Metodo criado para atender requisito da Tarefa 2
        // Criar uma função para verificar se a cidade existe.
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(CidadeDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> ObterPorId([FromRoute] int id)
        {
            var response = await _cidadeService.ObterPorIdAsync(id);

            if (response == null)
                return NotFound();

            return Ok(response);
        }


        [HttpPost]
        [ProducesResponseType(typeof(CidadeDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<CidadeDTO>> Adicionar([FromBody] CidadeDTO cidade)
        {
            var response = await _cidadeService.AdicionarAsync(cidade);

            if (_notificador.TemNotificacao())
                return BadRequest(new ValidationProblemDetails(_notificador.ObterNotificacoes()));

            return Ok(response);
        }


        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Atualizar([FromRoute] int id, [FromBody] CidadeDTO cidade)
        {
            if (id != cidade.Id) 
                return BadRequest();

            if (await _cidadeService.ObterPorIdAsync(id) == null)
                return NotFound();

            await _cidadeService.AtualizarAsync(cidade);

            if (_notificador.TemNotificacao())
                return BadRequest(new ValidationProblemDetails(_notificador.ObterNotificacoes()));


            return NoContent();
        }


    }
}
