using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafiRepay.RAO
{
    class PackageType
    {
        public string id { get; set; }
        public string amountMax { get; set; }
        public string name { get; set; }
        public List<PackageType> data { get; set; }

        public static List<PackageType> showPrices()
        {
            JObject jsonParse = JObject.Parse(RAO.get("price"));
            if (jsonParse["name"].ToString().Length == 0)
            {
                List<PackageType> listes = new List<PackageType>();
                JArray jsonData = jsonParse["data"].ToObject<JArray>();
                List<PackageType> stringtest = JsonConvert.DeserializeObject<List<PackageType>>(jsonData.ToString());

                foreach (PackageType onePackageType in stringtest)
                {
                    listes.Add(onePackageType);
                }
                return listes;
            }
            else
            {
                return null;
            }
        }
    }
}
