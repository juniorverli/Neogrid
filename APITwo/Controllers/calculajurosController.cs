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

    public static class MyExtensionMethods
    {
        public static string toFixed(this decimal number, uint decimals)
        {
            return number.ToString("N" + decimals);
        }
    }
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class calculajurosController : ControllerBase
    {
        string url = "http://localhost:22178/taxaJuros";
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<CalculaJuros> GetAsync(decimal valorinicial, int meses)
        {
            await RestRequest.GetRequestJuros(url);
            double juros = RestRequest.Juros;
            var result = (valorinicial * (decimal)Math.Pow((1 + (double)juros), meses));
            string valorfinal = result.toFixed(2);
            Console.WriteLine("Calcula Juros Compostos\n" +
            "Valor do Juros: " + juros +"\n" +
            "Valor Inicial: " + valorinicial + "\n" +
            "Quantidade de Meses: " + meses + "\n" +
            "Valor Final: " + valorfinal + "\n");
            return new CalculaJuros { ValorFinal = valorfinal };
        }
    }
}
