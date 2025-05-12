using Microsoft.AspNetCore.Mvc;

namespace NotificacoesAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestDbController : ControllerBase
    {
        [HttpGet("novidades")]
        public IActionResult GetNovidades()
        {
            try
            {
                int count = DbHelper.ObterNovidades();
                return Ok(new { TotalNovidades = count });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro: {ex.Message}");
            }
        }
    }
}
