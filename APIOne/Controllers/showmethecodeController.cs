using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIOne.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class showmethecodeController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public showmethecode Get()
        {
            return new showmethecode { github = "google.com" };
        }
    }
}
