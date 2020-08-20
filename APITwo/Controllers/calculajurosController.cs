using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        [HttpGet]
        public async Task<ActionResult<CalculaJuros>> GetAsync(decimal valorinicial, int meses)
        {
            try{await RestRequest.GetRequestJuros(url);}catch (Exception) { return NotFound();}
            double juros = RestRequest.Juros;
            var calc = (valorinicial * (decimal)Math.Pow((1 + (double)juros), meses));
            decimal decimalRounded = Decimal.Parse(calc.ToString("0.00"));
            var result = new CalculaJuros { ValorFinal = decimalRounded };
            return Ok(result);
        }
    }
}
