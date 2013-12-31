using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace Simple_BreweryDB_Wrapper
{
    public class BreweryDB
    {
        private const string baseUrl = "http://api.brewerydb.com/v2/";
        private string apiKey, endpoint, responseFormat, method;
        Dictionary<string, string> parameters = new Dictionary<string,string>();

        public BreweryDB(string key, string format)
        {
            this.apiKey = key;
            if (format == null)
                this.responseFormat = "json";
            else
                this.responseFormat = format;
        }

        public string Endpoint
        {
            get { return this.endpoint; }
            set { this.endpoint = value; }
        }

        public string Method
        {
            get { return this.method; }
            set { this.method = value; }
        }

        public Dictionary<string, string> Parameters
        {
            get { return this.parameters; }
            set { this.parameters = value; }
        }


        public string ExecuteGetCall(string page)
        {
            StringBuilder urlRequestBuilder = new StringBuilder(baseUrl);
            urlRequestBuilder.Append(this.endpoint);
            urlRequestBuilder.Append("?");
            foreach (KeyValuePair<string, string> parameter in this.parameters)
            {
                urlRequestBuilder.Append(parameter.Key);
                urlRequestBuilder.Append("=");
                urlRequestBuilder.Append(parameter.Value);
                urlRequestBuilder.Append("&");
            }
            if (page != null)
            {
                urlRequestBuilder.Append("p=");
                urlRequestBuilder.Append(page);
                urlRequestBuilder.Append("&");
            }

            urlRequestBuilder.Append("format=");
            urlRequestBuilder.Append(responseFormat);
            urlRequestBuilder.Append("&key=");
            urlRequestBuilder.Append(apiKey);
            string urlRequest = urlRequestBuilder.ToString();

            WebRequest request = WebRequest.Create(urlRequest);
            request.Method = this.method;
            WebResponse response = request.GetResponse();
            
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string results = reader.ReadToEnd();
            return results;
        }
    }
}
