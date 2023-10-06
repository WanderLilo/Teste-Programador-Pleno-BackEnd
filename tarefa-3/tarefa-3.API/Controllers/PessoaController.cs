using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;
using tarefa_3.ApplicationCore.DTOs;
using tarefa_3.ApplicationCore.Interfaces;
using tarefa_3.ApplicationCore.Notificador;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace tarefa_3.API.Controllers
{

    [Route("api/pessoa")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private readonly INotificador _notificador;
        private readonly IPessoaService _pessoaService;

        public PessoaController(INotificador notificador, IPessoaService pessoaService)
        {
            _notificador = notificador;
            _pessoaService = pessoaService;
        }


        [HttpPost]
        [ProducesResponseType(typeof(PessoaDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<PessoaDTO>> Adicionar([FromBody] PessoaDTO pessoa)
        {
            var response = await _pessoaService.AdicionarAsync(pessoa);

            if (_notificador.TemNotificacao())
                return BadRequest(new ValidationProblemDetails(_notificador.ObterNotificacoes()));

            return Ok(response);
        }


    }

}
