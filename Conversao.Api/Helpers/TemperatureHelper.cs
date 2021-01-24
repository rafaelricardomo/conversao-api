using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Conversao.Api
{
    public static class TemperatureHelper
    {
        
        //Para converter graus Celsius em graus Fahrenheit, multiplique por 1,8 e adicione 32.        
        public static decimal ConvertCelsiusToFahrenheit(decimal value)
        {
            return ((value * 1.8m) + 32);
        }
        // Para converter graus Fahrenheit em graus Celsius, subtraia 32 e divida por 1,8.
        public static decimal ConvertFahrenheitToCelsius(decimal value)
        {
            return ((value - 32m) / 1.8m);
        }

    }
}
