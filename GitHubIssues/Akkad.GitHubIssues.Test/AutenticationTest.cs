using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace Akkad.GitHubIssues.Test
{
    [TestClass]
    public class AutenticationTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var client = new RestClient
            {
                BaseUrl = "https://api.github.com",
                Authenticator = new HttpBasicAuthenticator(_username, _password)
            };

            var response = client.Execute(_restRequest);
        }
    }
}
