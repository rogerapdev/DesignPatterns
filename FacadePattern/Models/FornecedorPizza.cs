using FacadePattern.Interfaces;
using System;

namespace FacadePattern.Models
{
    public class FornecedorPizza : IPizza
    {
        private void ObterCoberturaNaoVegana()
        {
            Console.WriteLine("Obtendo coberturas não veganas");
        }

        public void BuscarNormal()
        {
            ObterCoberturaNaoVegana();
            Console.WriteLine("Buscando a Pizza normal");
        }

        public void BuscarVegana()
        {
            Console.WriteLine("Buscando a Pizza vegana");
        }
    }
}
