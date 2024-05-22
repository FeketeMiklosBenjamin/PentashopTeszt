using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pentashop_Teszt_Fekete_Miklos.utilities
{
    public class jsonReader
    {
        public List<string> productsDataList(string tokenName)
        {
            string myJsonString = File.ReadAllText("tests/productsHelper.json");
            var jsonObject = JToken.Parse(myJsonString);
            return jsonObject.SelectTokens(tokenName).Values<string>().ToList();
        }
    }
}
