using ObserverPattern.Interfaces;
using System;

namespace ObserverPattern
{
    public class NovasAgenciasNoticias : IObserver
    {

        public string NomeAgencia { get; set; }

        public NovasAgenciasNoticias(string NomeAgencia)
        {
            this.NomeAgencia = NomeAgencia;
        }

        public void Atualizar(ISubject subject)
        {
            if(subject is EstacaoMeteorologica estacao)
            {
                Console.WriteLine(string.Format("{0} reportando a Temperatura {1} graus celsius", NomeAgencia, estacao.Temperatura));
                Console.WriteLine();
            }
        }
    }
}
