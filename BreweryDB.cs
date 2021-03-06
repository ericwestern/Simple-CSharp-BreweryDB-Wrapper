﻿using System;
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
        private string apiKey, endpoint, responseFormat;

        public BreweryDB(string key, string format)
        {
            this.apiKey = key;
            this.responseFormat = format;
        }

        public string Endpoint
        {
            get { return this.endpoint; }
            set { this.endpoint = value; }
        }


        public string ExecuteGetCall(Dictionary<string, string> parameters)
        {
            StringBuilder urlRequestBuilder = new StringBuilder(baseUrl);
            urlRequestBuilder.Append(this.endpoint);
            urlRequestBuilder.Append("?");
            if (parameters != null)
            {
                foreach (KeyValuePair<string, string> parameter in parameters)
                {
                    urlRequestBuilder.Append(parameter.Key);
                    urlRequestBuilder.Append("=");
                    urlRequestBuilder.Append(parameter.Value);
                    urlRequestBuilder.Append("&");
                }
            }

            urlRequestBuilder.Append("format=");
            urlRequestBuilder.Append(responseFormat);
            urlRequestBuilder.Append("&key=");
            urlRequestBuilder.Append(apiKey);
            string urlRequest = urlRequestBuilder.ToString();

            return BreweryDbResponse(urlRequest, "GET");
        }

        public string DirectCallById(string id, Dictionary<string, string> parameters)
        {
            StringBuilder urlRequestBuilder = new StringBuilder(baseUrl);
            urlRequestBuilder.Append(this.endpoint);
            urlRequestBuilder.Append("/");
            urlRequestBuilder.Append(id);
            urlRequestBuilder.Append("?");
            if (parameters != null)
            {
                foreach (KeyValuePair<string, string> parameter in parameters)
                {
                    urlRequestBuilder.Append(parameter.Key);
                    urlRequestBuilder.Append("=");
                    urlRequestBuilder.Append(parameter.Value);
                    urlRequestBuilder.Append("&");
                }
            }
            urlRequestBuilder.Append("key=");
            urlRequestBuilder.Append(apiKey);
            string urlRequest = urlRequestBuilder.ToString();
            return BreweryDbResponse(urlRequest, "GET");
        }

        private string BreweryDbResponse(string url, string webMethod)
        {
            WebRequest request = WebRequest.Create(url);
            request.Method = webMethod;
            WebResponse response = request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream());
            string results = reader.ReadToEnd();
            return results;
        }
    }
}
