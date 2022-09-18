using FactoryMethodPattern.Products;

namespace FactoryMethodPattern.ConcreteProduct
{
    class CartaoPlatinium : CartaoCredito
    {
        private readonly string _tipo;
        private int _limite;
        private int _cobrancaAnual;

        public CartaoPlatinium(int limite, int cobranca)
        {
            this._tipo = "Platinium";
            this._limite = limite;
            this._cobrancaAnual = cobranca;
        }

        public override string Tipo
        {
            get { return _tipo; }
        }
        public override int Limite
        {
            get { return _limite; }
            set { _limite = value; }
        }
        public override int CobrancaAnual
        {
            get { return _cobrancaAnual; }
            set { _cobrancaAnual = value; }
        }
    }
}
