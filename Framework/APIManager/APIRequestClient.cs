using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.APIManager
{
    public class APIRequestClient
    {
        private string method;
        public IRestRequest _request { get; set; }

        public APIRequestClient(string method)
        {
            this.method = method;
        }

        public void SetRequest(string endPoint)
        {
            switch (method.ToUpper())
            {
                case "POST":
                    _request = new RestRequest(endPoint, Method.POST, DataFormat.Json);
                    break;
                case "GET":
                    _request = new RestRequest(endPoint, Method.GET, DataFormat.Json);
                    break;
                default:
                    _request = new RestRequest();
                    break;
            }
        }
    }
}
