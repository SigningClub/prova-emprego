using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Tasks.Deployment.Bootstrapper;
using MySql.Data.MySqlClient.Memcached;
using System.Net;
using WebApplication1.Imp;
using WebApplication1.Interface;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/compras")]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoInterface _repository;

        public ProdutoController(IProdutoInterface repository)
        {
            _repository = repository;
        }

        private readonly ILogger<ProdutoController> _logger;
        public ProdutoController(ILogger<ProdutoController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.GetAll()) ;
        }
    }
}


