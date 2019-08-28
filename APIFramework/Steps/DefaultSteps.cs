using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace APIFramework.Steps
{
    [Binding]
    public sealed class DefaultSteps
    {
        private readonly RestSession restSession;

        public DefaultSteps(RestSession restSession)
        {
            this.restSession = restSession;
        }

        [StepDefinition(@"the /(.*)/ resource")]
        public void GivenThe_Endpoint(string resourceValue)
        {
            this.restSession.Request.Resource = resourceValue;
        }
    }
}
