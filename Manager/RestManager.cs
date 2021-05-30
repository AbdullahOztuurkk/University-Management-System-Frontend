using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Serializers.NewtonsoftJson;
using System;
using System.Collections.Generic;
using System.Text;

namespace UniOtomasyonUI.Manager
{
    public class RestManager
    {
        private string BASE_URL = "http://localhost:5000";
        private static RestClient client;
        private IRestRequest request;
        private int parameter_count = 0, cookie_count = 0;
        private Dictionary<string, object> parameter_table;
        private Dictionary<string, string> cookie_table;

        public RestManager()
        {
            client = new RestClient(BASE_URL);
            client.UseNewtonsoftJson();
            request = new RestRequest();
            parameter_table = new Dictionary<string, object>();
            cookie_table = new Dictionary<string, string>();
        }

        public IRestResponse CreateHttpRequest(string endpoint, Method httpMethod, object jsonModel = null)
        {
            request = new RestRequest(endpoint, httpMethod, DataFormat.Json);
            if (httpMethod != Method.GET && jsonModel != null)
                request.AddJsonBody(jsonModel);
            if (parameter_count > 0)
            {
                foreach (KeyValuePair<string, object> item in parameter_table)
                {
                    request.AddParameter(item.Key, item.Value);
                }
            }
            if (cookie_count > 0)
            {
                foreach (KeyValuePair<string, string> item in cookie_table)
                {
                    request.AddCookie(item.Key, item.Value);
                }
            }
            var response = client.Execute(request);
            parameter_count = 0;
            cookie_count = 0;
            return response;
        }

        public void AddParameter(string name, object parameterModel)
        {
            parameter_count++;
            parameter_table.Add(name, parameterModel);
        }

        public void AddCookie(string key, string value)
        {
            cookie_count++;
            cookie_table.Add(key, value);
        }

        public JObject ResponseToJson(IRestResponse response)
        {
            var jObject = JsonConvert.DeserializeObject(response.Content);
            return (JObject)jObject;
        }

        public string ReadResponseField(IRestResponse response, string name)
        {
            var JObjectResponse = ResponseToJson(response);
            return JObjectResponse.GetValue(name).ToString();
        }
    }
}
