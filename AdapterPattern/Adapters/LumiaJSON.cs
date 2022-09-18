﻿using AdapterPattern.Interfaces;
using AdapterPattern.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdapterPattern.Adapters
{
    public class LumiaJSON : ILumiaJSON
    {
        public string GetLumiaMobilesJSONSpecifications()
        {
            List<LumiaMobile> listLumiaMobiles = new List<LumiaMobile>();
            listLumiaMobiles.Add(new LumiaMobile
            {
                IdModelo = "lumia550",
                Altura = "136.1 mm",
                Largura = "67.8 mm",
                Espessura = "9.9 mm",
                Peso = "141.9 g"
            });
            listLumiaMobiles.Add(new LumiaMobile
            {
                IdModelo = "lumia950",
                Altura = "145 mm",
                Largura = "73.2 mm",
                Espessura = "8.2 mm",
                Peso = "150 g"
            });
            listLumiaMobiles.Add(new LumiaMobile
            {
                IdModelo = "Text",
                Altura = "",
                Largura = "",
                Espessura = "8.2 mm",
                Peso = "150 g"
            });
            dynamic collectionLumiaMobiles = new
            {
                lumiaMobiles = listLumiaMobiles
            };
            return JsonConvert.SerializeObject(collectionLumiaMobiles);
        }
    }
}
