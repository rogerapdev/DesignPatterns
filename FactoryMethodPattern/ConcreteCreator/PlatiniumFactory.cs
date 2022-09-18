using FactoryMethodPattern.ConcreteProduct;
using FactoryMethodPattern.Creators;
using FactoryMethodPattern.Products;

namespace FactoryMethodPattern.ConcreteCreator
{
    public class PlatiniumFactory : CartaoFactory
    {
        private int _limite;
        private int _cobrancaAnual;

        public PlatiniumFactory(int limite, int cobrancaAnual)
        {
            this._limite = limite;
            this._cobrancaAnual = cobrancaAnual;
        }

        public override CartaoCredito BuscarCartao()
        {
            return new CartaoPlatinium(_limite, _cobrancaAnual);
        }
    }
}
