using FactoryMethodPattern.ConcreteProduct;
using FactoryMethodPattern.Creators;
using FactoryMethodPattern.Products;

namespace FactoryMethodPattern.ConcreteCreator
{
    public class BlackFactory : CartaoFactory
    {
        private int _limite;
        private int _cobrancaAnual;

        public BlackFactory(int limite, int cobrancaAnual)
        {
            this._limite = limite;
            this._cobrancaAnual = cobrancaAnual;
        }

        public override CartaoCredito BuscarCartao()
        {
            return new CartaoBlack(_limite, _cobrancaAnual);
        }
    }
}
