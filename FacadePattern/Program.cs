using FacadePattern.Facades;
using System;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var facade = new Restaurante();

            Console.WriteLine("******** PEDIDOS DE PIZZA ********\n");
            facade.BuscarPizzaNormal();
            facade.BuscarPizzaVegana();

            Console.WriteLine("\n******** PEDIDOS DE PÃO ********\n");
            facade.BuscarPaoDeAlho();
            facade.BuscarPaoDeAlhoComQueijo();


        }
    }
}
