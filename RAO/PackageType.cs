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
        public int employee_id { get; set; }
        public int middayMeal { get; set; }
        public int relayStage { get; set; }
        public int overnight { get; set; }
        public int kms { get; set; }
        public DateTime date { get; set; }
        public string name { get; set; }
        public List<PackageType> data { get; set; }

        public static PackageType getPackageType(int employee_id)
        {
            JObject jsonParse = JObject.Parse(RAO.post("packageType", "employee_id=" + employee_id));
            if (employee_id.ToString().Length > 0)
            {
                return JsonConvert.DeserializeObject<PackageType>(jsonParse.ToString());
            }
            else
            {
                return null;
            }
        }

        public static PackageType modifyPackageType(int employee_id, int middayMeal, int relayStage, int overnight, int kms)
        {
            JObject jsonParse = JObject.Parse(RAO.put("modifyPackageType", "employee_id=" + employee_id + "&middayMeal=" + middayMeal +
                "&relayStage=" + relayStage + "&overnight=" + overnight + "&kms=" + kms));
            if(employee_id.ToString().Length > 0)
            {
                return JsonConvert.DeserializeObject<PackageType>(jsonParse.ToString());
            }
            else
            {
                return null;
            }
        }
    }
}
