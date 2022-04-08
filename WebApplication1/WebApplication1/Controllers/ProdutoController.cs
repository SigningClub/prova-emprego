using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Tasks.Deployment.Bootstrapper;
using MySql.Data.MySqlClient.Memcached;
using System.Net;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/compras")]
    public class ProdutoController : ControllerBase
    {
        MyDBContext dbContext;
        private readonly ILogger<ProdutoController> _logger;
        public ProdutoController(ILogger<ProdutoController> logger)
        {
            _logger = logger;
        }
        /// <summary>
        /// Cadastrar produto.
        /// </summary>
        /// <param name="produto">Modelo do produto.</param>
        /// <response code="200">O produto foi cadastrado com sucesso.</response>
        /// <response code="400">um erro desconhecido.</response>
        /// <response code="412">Os valores informados não são válidos.</response>
        [HttpPost(Name ="Post Primeira Alternativa")]
        public IActionResult Post(ProdutoPostVm produto)
        {
            try
            {
                dbContext.Add(produto);
                dbContext.SaveChanges();
                return StatusCode((int)HttpStatusCode.Created);
            }
            catch (Exception)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError);
            }
        }
        List<ProdutoBaseVm> product = new List<ProdutoBaseVm>();
        public ProdutoController()
        {
            product.Add(new ProdutoBaseVm { Name = "Tim", Price = 10000, qtd = 1 });
            product.Add(new ProdutoBaseVm { Name = "Sam", Price = 500000, qtd = 2 });
            product.Add(new ProdutoBaseVm { Name = "Peter", Price = 500001, qtd = 3 });
        }
        [HttpGet]
        public IEnumerable<ProdutoBaseVm> Get()
        {
            return product;
        }
    }
}


