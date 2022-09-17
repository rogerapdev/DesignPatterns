using AbstractFactoryPattern.Interfaces;
using AbstractFactoryPattern.Products;
using System;

namespace AbstractFactoryPattern.Concretes
{
    public class Samsung : ITelemovel
    {
        public INormalPhone BuscarNormalPhone()
        {
            return new SamsungGuru();
        }

        public ISmartPhone BuscarSmartPhone()
        {
            return new SamsungGalaxy();
        }
    }
}
