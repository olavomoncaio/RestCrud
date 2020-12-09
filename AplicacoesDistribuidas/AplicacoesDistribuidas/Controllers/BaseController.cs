using AplicacoesDistribuidas.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace AplicacoesDistribuidas.Controllers
{
    [ApiController]
    [Produces("application/json")]
    public class BaseController : ControllerBase
    {
        private readonly ILogger _logger;
        protected readonly ICardapioService _cardapioService;
        private readonly string MensagemErroPadrao = "Ocorreu um erro ao processar a solicitação. Por favor, tente novamente mais tarde.";

        protected BaseController(ILogger logger, ICardapioService service)
        {
            _logger = logger;
            _cardapioService = service;
        }

        protected async Task<IActionResult> TratarResultadoAsync(Func<Task<IActionResult>> service)
        {
            try
            {
                return await service();
            }
            catch (Exception ex)
            {
                _logger.LogError($"{ex.Message} {ex.StackTrace}");
                return StatusCode(StatusCodes.Status500InternalServerError, new { Mensagem = MensagemErroPadrao });
            }
        }
    }
}
