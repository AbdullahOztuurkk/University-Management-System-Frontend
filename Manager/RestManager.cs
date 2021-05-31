using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Serializers.NewtonsoftJson;
using System.Collections.Generic;

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
        /// <summary>
        /// Create a http request with parameters and cookies
        /// </summary>
        /// <param name="endpoint">api endpoint url</param>
        /// <param name="httpMethod">Http method type</param>
        /// <param name="jsonModel">Any object for request</param>
        /// <returns>IRestResponse</returns>
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
            parameter_table.Clear();
            cookie_table.Clear();
            return response;
        }
        /// <summary>
        /// Add Parameter before create http request
        /// </summary>
        /// <param name="name">Parameter name</param>
        /// <param name="parameterModel">Parameter Value</param>
        public void AddParameter(string name, object parameterModel)
        {
            parameter_count++;
            parameter_table.Add(name, parameterModel);
        }

        /// <summary>
        /// Add Cookie before create http request
        /// </summary>
        /// <param name="key">Cookie Name</param>
        /// <param name="value">Cookie Value</param>
        public void AddCookie(string key, string value)
        {
            cookie_count++;
            cookie_table.Add(key, value);
        }

        /// <summary>
        /// Convert IRestResponse to Json
        /// </summary>
        /// <param name="response">IRestResponse object</param>
        /// <returns></returns>
        public JObject ResponseToJson(IRestResponse response)
        {
            var jObject = JsonConvert.DeserializeObject(response.Content);
            return (JObject)jObject;
        }
        /// <summary>
        /// Read specified field in RestResponse
        /// </summary>
        /// <param name="response">IRestResponse object</param>
        /// <param name="name">Specific field name</param>
        /// <returns></returns>
        public string ReadResponseField(IRestResponse response, string name)
        {
            var JObjectResponse = ResponseToJson(response);
            return JObjectResponse.GetValue(name).ToString();
        }
    }
}
