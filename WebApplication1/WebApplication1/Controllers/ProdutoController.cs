using Microsoft.AspNetCore.Mvc;
using System.Net;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly ILogger<ProdutoController> _logger;
        public ProdutoController(ILogger<ProdutoController> logger)
        {
            _logger = logger;
        }
        /// <summary>
        /// Cadastrar produto.
        /// </summary>
        /// <param name="produto">Modelo do usuário.</param>
        /// <response code="200">O produto foi cadastrado com sucesso.</response>
        /// <response code="400">um erro desconhecido.</response>
        /// <response code="412">Os valores informados não são válidos.</response>
        [HttpPost]
        public IActionResult Post(ProdutoPostVm produto)
        {
            try
            {
                return StatusCode((int)HttpStatusCode.Created);
            }
            catch (Exception)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError);
            }
        }
    }
}

