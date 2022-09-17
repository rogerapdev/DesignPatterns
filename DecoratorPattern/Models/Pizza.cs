using DecoratorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Models
{
    public class Pizza : IPizza
    {
        public string BuscarTipo()
        {
            var pizza = "tipo pizza normal";

            return pizza;
        }
    }
}
