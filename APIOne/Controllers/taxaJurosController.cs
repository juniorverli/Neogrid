using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace APIOne.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class taxaJurosController : ControllerBase
    {
        private readonly double jurosvalue = 0.01;
        private readonly ILogger _logger;

        public taxaJurosController(ILogger<taxaJurosController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult <taxaJuros> Get()
        {
            var result = new taxaJuros { Juros = jurosvalue };
            _logger.LogInformation($"Valor do Juros: {jurosvalue}");
            return Ok(result);
        }
    }
}
