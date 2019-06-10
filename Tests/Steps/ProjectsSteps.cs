using Framework.APIManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Tests.Steps
{
    [Binding]
    class ProjectsSteps
    {
        private APIRestClient _client = null;
        private APIRequestClient _request = null;
        private APIResponseClient _response = new APIResponseClient();

        [Given(@"I am in  ""(.*)"" page")]
        public void GivenIAmInPage(string url)
        {
            _client = new APIRestClient(url);
        }

        [Given(@"I have entered my credentials ""(.*)"", ""(.*)""")]
        public void GivenIHaveEnteredMyCredentials(string userName, string password)
        {
            _client.SetCredentials(userName, password);
        }

        [When(@"I GET all projetcs from ""(.*)"" endpoint")]
        public void WhenIGETAllProjetcsFromEndpoint(string endPoint)
        {
            _request = new APIRequestClient("GET");
            _request.SetRequest(endPoint);
        }


        [Then(@"the status code should be (.*)")]
        public void ThenTheStatusCodeShouldBe(int statusCode)
        {
            var res = _response.ExecuteRequest(_client, _request);
        }

    }
}
