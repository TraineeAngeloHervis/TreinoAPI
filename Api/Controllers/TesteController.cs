using Crosscutting;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TesteController : ControllerBase
    {
        [HttpGet("teste")]
        public IActionResult Testar(
            [FromQuery] TesteRequisicaoDto requisicao,
            [FromServices] ITesteService service)
        {
            var resposta = service.TesteMetodo(requisicao);

            return Ok(resposta);
        }
    }
}
