using AbstractFactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class TelemovelClient
    {
        ISmartPhone smartPhone;
        INormalPhone normalPhone;

        public TelemovelClient(ITelemovel factory)
        {
            smartPhone = factory.BuscarSmartPhone();
            normalPhone = factory.BuscarNormalPhone();
        }

        public string BuscarSmartPhoneDetalhes()
        {
            return smartPhone.BuscarDetalhes();
        }

        public string BuscarNormalPhoneDetalhes()
        {
            return normalPhone.BuscarDetalhes();
        }
    }
}
