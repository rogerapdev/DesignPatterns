using AbstractFactoryPattern.Concretes;
using AbstractFactoryPattern.Interfaces;
using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ITelemovel nokia = new Nokia();
            ITelemovel samsung = new Samsung();

            TelemovelClient client = new TelemovelClient(nokia);

            Console.WriteLine("********* NOKIA *********");
            Console.WriteLine(client.BuscarSmartPhoneDetalhes());
            Console.WriteLine(client.BuscarNormalPhoneDetalhes());

            client = new TelemovelClient(samsung);

            Console.WriteLine("********* SAMSUNG *********");
            Console.WriteLine(client.BuscarSmartPhoneDetalhes());
            Console.WriteLine(client.BuscarNormalPhoneDetalhes());

            Console.WriteLine();
        }
    }
}
