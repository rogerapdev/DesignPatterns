using Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Models
{
    public class Pizza : IPizza
    {
        public string BuscarTipo()
        {
            var pizza = "tipo pizza";

            return pizza;
        }
    }
}
