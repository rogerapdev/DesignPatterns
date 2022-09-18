using FacadePattern.Interfaces;
using System;

namespace FacadePattern.Models
{
    public class FornecedorPao : IPao
    {
        private void BuscarQueijo()
        {
            Console.WriteLine("Obtendo Queijo");
        }

        public void BuscarPaoDeAlho()
        {
            Console.WriteLine("Buscando o Pão de Alho");
        }

        public void BuscarPaoDeAlhoComQueijo()
        {
            BuscarQueijo();
            Console.WriteLine("Buscando o Pão de Alho com Queijo");
        }
    }
}
