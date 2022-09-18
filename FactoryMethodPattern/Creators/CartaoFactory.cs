using FactoryMethodPattern.Products;

namespace FactoryMethodPattern.Creators
{
    public abstract class CartaoFactory
    {
        public abstract CartaoCredito BuscarCartao();
    }
}
