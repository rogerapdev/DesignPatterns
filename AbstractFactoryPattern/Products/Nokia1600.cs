using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern.Products
{
    public class Nokia1600 : INormalPhone
    {
        public string BuscarDetalhes()
        {
            return "Model: Nokia 1600\nRAM: NA\nCamera: NA\n";
        }
    }
}
