using Microsoft.AspNetCore.Mvc;

namespace NotificacoesAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NotificacoesController : ControllerBase
    {
        [HttpGet("novas")]
        public IActionResult GetNovidades()
        {
            var count = DbHelper.ObterNovidades();
            return Ok(new { novasTarefas = count });
        }
    }
}
