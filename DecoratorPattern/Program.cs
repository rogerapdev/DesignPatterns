using DecoratorPattern.Decorators;
using DecoratorPattern.Interfaces;
using DecoratorPattern.Models;
using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //mesma interface com objetos diferentes
            IPizza pizza = new Pizza();
            IPizza queijo = new QueijoDecorator(pizza);
            IPizza bacon = new BaconDecorator(queijo);
            IPizza cebola = new CebolaDecorator(bacon);

            Console.WriteLine(cebola.BuscarTipo());
        }
    }
}
