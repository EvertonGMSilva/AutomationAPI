using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Automation.Steps
{
    [Binding]
    class TesteApiSteps 
    {
        int status;

        [When(@"faco a requisicao usando a (.*)")]
        public void QuandoFacoARequisicaoUsandoA(string city)
        {
            var client = new RestClient($"https://api.weatherbit.io/v2.0/current?city={city}&key=6b7249db33e048d69bf71a79d5e6e95e");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            status = (int) response.StatusCode;
        }

        [Then(@"o status code deve ser (.*)")]
        public void EntaoOStatusCodeDeveSer(int status)
        {
            Assert.AreEqual(this.status, status);
        }
    }
}
