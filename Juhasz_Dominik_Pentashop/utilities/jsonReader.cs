using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pentashop_Teszt_Juhasz_Dominik.utilities
{
    public class jsonReader
    {
        public List<string> productsDataList(string tokenName)
        {
            string myJsonString = File.ReadAllText("tests/usersProfile.json");
            var jsonObject = JToken.Parse(myJsonString);
            return jsonObject.SelectTokens(tokenName).Values<string>().ToList();
        }
    }
}
