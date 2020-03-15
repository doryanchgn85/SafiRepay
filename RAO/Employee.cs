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
        public int employee_type_id { get; set; }
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
        public int activation { get; set; }
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

        public static Employee createAccountEmployee(int activation, String lastname, String firstname, String pwd, String login, String address, String PC, String city, String phone, String hireDateDay, String hireDateMonth, String hireDateYear, int district)
        {
            JObject jsonParse = JObject.Parse(RAO.post("createAccountEmployee", "activation=" + activation + "&firstname=" + firstname + "&lastname=" + lastname + "&password=" + pwd + "&login=" + login + 
                "&address=" + address + "&postalCode=" + PC + "&city=" + city + "&phone=" + phone + "&hireDate=" + hireDateYear + "/" + hireDateMonth + "/" + hireDateDay + "&district_id=" + district));
            if (lastname.ToString().Length > 0)
            {
                return JsonConvert.DeserializeObject<Employee>(jsonParse.ToString());
            }
            else
            {
                return null;
            }
        }

        public static Employee researchEmployee(String login)
        {
            JObject jsonParse = JObject.Parse(RAO.post("researchEmployee", "login=" + login));
            
            if (jsonParse["lastname"].ToString().Length > 0)
            {
                return JsonConvert.DeserializeObject<Employee>(jsonParse.ToString());
            }
            else
            {
                return null;
            }
        }

        public static Employee modifyEmployee(String login, String lastname, String firstname, String address, String city, String postalCode, String phone, int activation)
        {
            JObject jsonParse = JObject.Parse(RAO.put("modifyAccountEmployee", "login=" + login + "&lastname=" + lastname + "&firstname=" + firstname + "&address=" + address + 
                "&city=" + city + "&postalCode=" + postalCode + "&phone=" + phone + "&activation=" + activation));
            
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