using AplicacoesDistribuidas.Interfaces;
using AplicacoesDistribuidas.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace AplicacoesDistribuidas.Controllers
{
    [Route("[controller]")]
    public class CardapioController : BaseController
    {
        public CardapioController(ILogger<CardapioController> logger, ICardapioService service) : base(logger, service)
        {
        }

        [HttpPost]
        public async Task<IActionResult> Cadastrar([FromBody] CadastrarItemRequest request)
        {
            return await TratarResultadoAsync(async () =>
            {
                var resultado = await _cardapioService.Cadastrar(request);

                return new ObjectResult(resultado) { StatusCode = StatusCodes.Status200OK };
            });
        }

        [HttpGet]
        public async Task<IActionResult> Obter()
        {
            return await TratarResultadoAsync(async () =>
            {
                var resultado = await _cardapioService.ObterCardapio();

                return new ObjectResult(resultado) { StatusCode = StatusCodes.Status200OK };
            });
        }

        [HttpPut]
        public async Task<IActionResult> Atualizar([FromBody] AtualizarItemRequest request)
        {
            return await TratarResultadoAsync(async () =>
            {
                var resultado = await _cardapioService.Atualizar(request);

                return new ObjectResult(resultado) { StatusCode = StatusCodes.Status200OK };
            });
        }

        [HttpDelete]
        public async Task<IActionResult> Excluir([FromQuery] int id)
        {
            return await TratarResultadoAsync(async () =>
            {
                var resultado = await _cardapioService.Excluir(id);

                return new ObjectResult(resultado) { StatusCode = StatusCodes.Status200OK };
            });
        }

        [HttpGet("ObterItem")]
        public async Task<IActionResult> ObterItem([FromQuery] int id)
        {
            return await TratarResultadoAsync(async () =>
            {
                var resultado = await _cardapioService.ObterItem(id);

                return new ObjectResult(resultado) { StatusCode = StatusCodes.Status200OK };
            });
        }

    }
}
