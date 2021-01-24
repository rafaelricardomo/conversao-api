using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Conversao.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConvertController : ControllerBase
    {

        private readonly ILogger<ConvertController> _logger;

        public ConvertController(ILogger<ConvertController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("Fahrenheit/{value}/Celsius")]
        public decimal GetConvertFahrenheitToCelsius(decimal value)
        {
            return TemperatureHelper.ConvertFahrenheitToCelsius(value);
        }

        [HttpGet]
        [Route("Celsius/{value}/Fahrenheit")]
        public decimal ConvertCelsiusToFahrenheit(decimal value)
        {
            return TemperatureHelper.ConvertCelsiusToFahrenheit(value);
        }
    }
}
