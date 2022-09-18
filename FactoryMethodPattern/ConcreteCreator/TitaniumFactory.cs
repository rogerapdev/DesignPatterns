using FactoryMethodPattern.ConcreteProduct;
using FactoryMethodPattern.Creators;
using FactoryMethodPattern.Products;

namespace FactoryMethodPattern.ConcreteCreator
{
    public class TitaniumFactory : CartaoFactory
    {
        private int _limite;
        private int _cobrancaAnual;

        public TitaniumFactory(int limite, int cobrancaAnual)
        {
            this._limite = limite;
            this._cobrancaAnual = cobrancaAnual;
        }

        public override CartaoCredito BuscarCartao()
        {
            return new CartaoTitanium(_limite, _cobrancaAnual);
        }
    }
}
