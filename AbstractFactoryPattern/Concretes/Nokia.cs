using AbstractFactoryPattern.Interfaces;
using AbstractFactoryPattern.Products;
using System;

namespace AbstractFactoryPattern.Concretes
{
    public class Nokia : ITelemovel
    {
        public INormalPhone BuscarNormalPhone()
        {
            return new Nokia1600();
        }

        public ISmartPhone BuscarSmartPhone()
        {
            return new NokiaPixel();
        }
    }
}
