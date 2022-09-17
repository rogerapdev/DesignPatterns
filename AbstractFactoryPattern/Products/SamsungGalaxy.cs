using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern.Products
{
    public class SamsungGalaxy : ISmartPhone
    {
        public string BuscarDetalhes()
        {
            return "Model: Samsung Galaxy\nRAM: 2GB\nCamera: 13MP\n";
        }
    }
}
