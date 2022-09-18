using AdapterPattern.Adapters;
using AdapterPattern.Interfaces;
using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ILumiaXML target = new LumiaXML();
            var xmlLumiaMobile = target.GetLumiaMobilesXMLSpecifications();
            Console.WriteLine(xmlLumiaMobile.InnerText);
        }
    }
}
