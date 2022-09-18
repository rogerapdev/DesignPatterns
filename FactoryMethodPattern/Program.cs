using FactoryMethodPattern.ConcreteCreator;
using FactoryMethodPattern.Creators;
using FactoryMethodPattern.Products;
using System;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CartaoFactory factory = null;


            Console.WriteLine("Digite o tipo de cartão:");
            string tipoCartao = Console.ReadLine();
            switch (tipoCartao.ToLower())
            {
                case "black":
                    factory = new BlackFactory(5000, 0);
                    break;
                case "titanium":
                    factory = new TitaniumFactory(10000, 500);
                    break;
                case "platinium":
                    factory = new PlatiniumFactory(100000, 1000);
                    break;
                default:
                    break;
            }

            CartaoCredito cartao = factory.BuscarCartao();
            Console.WriteLine("Detalhes do cartão: \n");
            Console.WriteLine("Tipo: {0}\n Limite: {1}\n Cobrança Anual: {2}\n", cartao.Tipo, cartao.Limite, cartao.CobrancaAnual);

        }
    }
}
