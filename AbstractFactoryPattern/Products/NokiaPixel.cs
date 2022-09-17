using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern.Products
{
    public class NokiaPixel : ISmartPhone
    {
        public string BuscarDetalhes()
        {
            return "Model: Nokia Pixel\nRAM: 3GB\nCamera: 8MP\n";
        }
    }
}
