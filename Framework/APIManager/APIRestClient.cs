using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.APIManager
{
    public class APIRestClient
    {
        private IRestClient _client;

        public APIRestClient(string urlBase)
        {
            _client = new RestClient(urlBase);
        }

        internal object Execute(IRestRequest request)
        {
            return _client.Execute(request);
        }

        public void SetCredentials(string userName, string password)
        {
            _client.Authenticator = new HttpBasicAuthenticator(userName,password);
        }
    }
}
