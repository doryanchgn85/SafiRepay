using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SafiRepay.RAO
{
    class RAO
    {
        /**
         * Get Method
         */
        public static String get(String route)
        {
            RestClient client = new RestClient();
            client.BaseUrl = new Uri(Properties.Settings.Default.routeApi);
            
            RestRequest request = new RestRequest();
            if(Global.connectedEmployee != null)
            {
                request.AddHeader("Authorization", "Bearer "+Global.connectedEmployee.token);
            }
            request.Resource = route;
            IRestResponse response = client.Execute(request);
            return response.Content;
        }

        /**
         * PUT Method #1
         */
        public static T Put<T>(string route, object requestObject)
        {
            RestClient client = new RestClient
            {
                BaseUrl = new Uri(Properties.Settings.Default.routeApi)
            };

            RestRequest request = new RestRequest(route, Method.PUT);
            if (Global.connectedEmployee != null)
            {
                request.AddHeader("Authorization", "Bearer " + Global.connectedEmployee.token);
            }

            string requestJson = JsonConvert.SerializeObject(requestObject);

            request.AddHeader("content-type", "application/json");
            request.AddParameter("application/json", requestJson, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            if(response == null)
            {
                return default;
            }

            return JsonConvert.DeserializeObject<T>(response.Content);
        }

        /**
         * Put Method #2
         */
        public static String put(String route, String paramRoute)
        {
            RestClient client = new RestClient();
            client.BaseUrl = new Uri(Properties.Settings.Default.routeApi);
            
            RestRequest request = new RestRequest(route, Method.PUT);
            if (Global.connectedEmployee != null)
            {
                request.AddHeader("Authorization", "Bearer " + Global.connectedEmployee.token);
            }
            request.AddHeader("content-type", "application/x-www-form-urlencoded");
            request.AddParameter("application/x-www-form-urlencoded", $"" + paramRoute, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }

        /**
         * POST Method
         */
        public static String post(String route, String paramRoute)
        {
            RestClient client = new RestClient();
            client.BaseUrl = new Uri(Properties.Settings.Default.routeApi);
            
            RestRequest request = new RestRequest(route, Method.POST);
            if (Global.connectedEmployee != null)
            {
                request.AddHeader("Authorization", "Bearer " + Global.connectedEmployee.token);
            }
            request.AddHeader("content-type", "application/x-www-form-urlencoded");
            request.AddParameter("application/x-www-form-urlencoded", $""+paramRoute, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }


        /**
         * DELETE Method
         */
        public static String delete(String route, String paramRoute)
        {
            RestClient client = new RestClient();
            client.BaseUrl = new Uri(Properties.Settings.Default.routeApi);
            
            RestRequest request = new RestRequest(route, Method.DELETE);
            if (Global.connectedEmployee != null)
            {
                request.AddHeader("Authorization", "Bearer " + Global.connectedEmployee.token);
            }
            request.AddJsonBody(paramRoute);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }
    }
}


