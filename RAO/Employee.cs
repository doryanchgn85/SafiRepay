using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace SafiRepay.RAO
{
    public class Employee
    {
        public String id { get; set; }
        public String code { get; set; }
        public String employee_type_id { get; set; }
        public String firstname { get; set; }
        public String lastname { get; set; }
        public String login { get; set; }
        public String password { get; set; }
        public String address { get; set; }
        public String postalCode { get; set; }
        public String city { get; set; }
        public String phone { get; set; }
        public String role { get; set; }
        public String hireDate { get; set; }
        public String timespan { get; set; }
        public String token { get; set; }
        public String district_id { get; set; }
        public String message { get; set; }
        public String data { get; set; }

        public static Employee auth(String login, String password)
        {
            // Transforme la chaine de caractère du RAO en objet JSON = parser
            JObject jsonParse = JObject.Parse(RAO.post("auth", "login="+login+"&password="+password));
            if (jsonParse["token"].ToString().Length > 0)
            {
                // Retourne un objet de la classe Login à partir de la chaine de caractère de l'objet JSON parsé avec clef "content"
                return JsonConvert.DeserializeObject<Employee>(jsonParse.ToString());
            }
            else
            {
                return null;
            }
        }

        public static Employee createAccountEmployee(String lastname, String firstname, int district)
        {
            JObject jsonParse = JObject.Parse(RAO.post("createAccountEmployee", "lastname=" + lastname + "&firstname=" + firstname + "&district_id=" + district));
            if (lastname.ToString().Length > 0)
            {
                return JsonConvert.DeserializeObject<Employee>(jsonParse.ToString());
            }
            else
            {
                return null;
            }
        }
    }
}