using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.APIManager
{
    public class APIResponseClient
    {
        public object ExecuteRequest(APIRestClient client, APIRequestClient request)
        {
            return client.Execute(request._request);
        }
    }
}
