﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCodeCamp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperationsController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public OperationsController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpOptions("ReloadConfug")]
        public IActionResult ReloadConfug()
        {
            try
            {
                var root = (IConfigurationRoot)_configuration;
                root.Reload();
                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
