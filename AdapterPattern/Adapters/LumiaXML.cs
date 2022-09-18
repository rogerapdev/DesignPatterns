using AdapterPattern.Interfaces;
using Newtonsoft.Json;
using System.Xml;

namespace AdapterPattern.Adapters
{
    public class LumiaXML : ILumiaXML
    {
        public XmlDocument GetLumiaMobilesXMLSpecifications()
        {
            LumiaJSON adapter = new LumiaJSON();
            string json = adapter.GetLumiaMobilesJSONSpecifications();
            var doc = JsonConvert.DeserializeXmlNode(json, "MicrosoftLumiaMobiles", true);
            return doc;
        }
    }
}
