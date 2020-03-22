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
        public decimal middayMeal { get; set; }
        public decimal relayStage { get; set; }
        public decimal overnight { get; set; }
        public decimal kms { get; set; }
        public DateTime date { get; set; }

        /*
         * GetPackageType Method
         * It is used tu get all package type price with the employee_id -> display according to the connected employee
         */
        public static PackageType getPackageType(int employee_id, String date)
        {
            JObject jsonParse = JObject.Parse(RAO.post("packageType", "employee_id=" + employee_id + "&date=" + date));
            if (employee_id.ToString().Length > 0)
            {
                return JsonConvert.DeserializeObject<PackageType>(jsonParse.ToString());
            }
            else
            {
                return null;
            }
        }

        /**
         * ModifyPackageType Method
         * Ut is used to modify th price of a package
         */
        public static PackageType modifyPackageType(int employee_id, decimal middayMeal, decimal relayStage, decimal overnight, decimal kms)
        {
            PackageType packageType = new PackageType
            {
                employee_id = employee_id,
                middayMeal = middayMeal,
                relayStage = relayStage,
                overnight = overnight,
                kms = kms
            };

            return RAO.Put<PackageType>("modifyPackageType", packageType);
        }
    }
}