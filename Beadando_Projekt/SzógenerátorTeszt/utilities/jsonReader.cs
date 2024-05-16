using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzógenerátorTeszt.utilities
{
    public class jsonReader
    {
        public List<string> extractDataList(string tokenName)
        {
            string myJsonString = File.ReadAllText("tests/testData.json");
            var jsonObject = JToken.Parse(myJsonString);
            return jsonObject.SelectToken(tokenName).Values<string>().ToList();
        }
    }
}
