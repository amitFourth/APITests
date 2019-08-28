using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using TechTalk.SpecFlow;

namespace APIFramework.Steps
{
    public class RestSession
    {
        private readonly SpecFlowContext scenarioContext;

        public RestSession(IRestClient restClient, IRestRequest restRequest, SpecFlowContext scenarioContext)
        {
            this.Client = restClient;
            this.Request = restRequest;
            this.scenarioContext = scenarioContext;
        }

        public IRestRequest Request { get; }

        public IRestClient Client { get; }

        public IRestResponse Response => this.scenarioContext.Get<IRestResponse>();

        public void Execute()
        {
            this.scenarioContext.Set(this.Client.Execute(this.Request));
        }
    }
}
