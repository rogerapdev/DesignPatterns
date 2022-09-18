using FacadePattern.Interfaces;
using FacadePattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern.Facades
{
    public class Restaurante
    {
        private IPizza _fornecedorPizza;
        private IPao _fornecedorPao;

        public Restaurante()
        {
            this._fornecedorPizza = new FornecedorPizza();
            this._fornecedorPao = new FornecedorPao();

        }

        public void BuscarPizzaNormal()
        {
            this._fornecedorPizza.BuscarNormal();
        }

        public void BuscarPizzaVegana()
        {
            this._fornecedorPizza.BuscarVegana();
        }

        public void BuscarPaoDeAlho()
        {
            this._fornecedorPao.BuscarPaoDeAlho();
        }

        public void BuscarPaoDeAlhoComQueijo()
        {
            this._fornecedorPao.BuscarPaoDeAlhoComQueijo();
        }
    }
}
