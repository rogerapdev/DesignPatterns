using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern.Products
{
    public class SamsungGuru : INormalPhone
    {
        public string BuscarDetalhes()
        {
            return "Model: Samsung Guru\nRAM: NA\nCamera: NA\n";
        }
    }
}
