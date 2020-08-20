using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace APITwo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class showmethecodeController : ControllerBase
    {
        private readonly string pathcode = "https://github.com/juniorverli/Neogrid";

        private readonly ILogger _logger;

        public showmethecodeController(ILogger<showmethecodeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult <showmethecode> Get()
        {
            var result = new showmethecode { GitHub = pathcode };
            var Message = $"Endereço do GitHub: {pathcode}";
            _logger.LogInformation(Message);
            return Ok(result);
        }
    }
}
