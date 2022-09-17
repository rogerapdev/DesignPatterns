using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            EstacaoMeteorologica estacao = new EstacaoMeteorologica();
            NovasAgenciasNoticias agencia1 = new NovasAgenciasNoticias("Agencia São Paulo");
            NovasAgenciasNoticias agencia2= new NovasAgenciasNoticias("Agencia Rio");

            estacao.Anexar(agencia1);
            estacao.Anexar(agencia2);

            estacao.Temperatura = 31.4f;
            estacao.Temperatura = 25f;
            estacao.Temperatura = 26.7f;
            //estacao.Temperatura = 34.7f;
            //estacao.Temperatura = 22.6f;

            Console.ReadLine();
        }
    }
}
