﻿using System;
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
        [HttpGet]
        public ActionResult <taxaJuros> Get()
        {
            var result = new taxaJuros { Juros = jurosvalue };
            return Ok(result);
        }
    }
}
