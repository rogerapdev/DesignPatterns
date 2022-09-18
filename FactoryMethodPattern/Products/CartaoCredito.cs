namespace FactoryMethodPattern.Products
{
    public abstract class CartaoCredito
    {
        public abstract string Tipo { get; }
        public abstract int Limite { get; set; }
        public abstract int CobrancaAnual { get; set; }
    }
}
