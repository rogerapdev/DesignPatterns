using DecoratorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Decorators
{
    //Concreate Decorator
    public class BaconDecorator : PizzaDecorator
    {
        public BaconDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string BuscarTipo()
        {
            var pizza = base.BuscarTipo();
            pizza += "\r\n com extra de bacon";

            return pizza;
        }
    }
}
