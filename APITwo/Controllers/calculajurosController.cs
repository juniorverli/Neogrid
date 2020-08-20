using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace APITwo.Controllers
{

    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class calculajurosController : ControllerBase
    {
        private readonly string url = "http://localhost:5000/taxaJuros";

        private readonly ILogger _logger;

        public calculajurosController(ILogger<calculajurosController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<CalculaJuros>> GetAsync(decimal valorinicial, int meses)
        {
            try{await RestRequest.GetRequestJuros(url);}catch (Exception) { return NotFound();}
            double juros = RestRequest.Juros;
            var calc = (valorinicial * (decimal)Math.Pow((1 + (double)juros), meses));
            decimal decimalRounded = Decimal.Parse(calc.ToString("0.00"));
            var result = new CalculaJuros { ValorFinal = decimalRounded };
            var Message = "Calcula Juros Compostos = " +
            $"Juros: {juros} | Valor Inicial: {valorinicial} | Meses: {meses} | Valor Final: {decimalRounded}";
            _logger.LogInformation(Message);
            return Ok(result);
        }
    }
}
