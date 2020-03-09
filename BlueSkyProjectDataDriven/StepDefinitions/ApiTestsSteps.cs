using BlueSkySeleniumSpecflowWaitsDataDrivenAssertionsPageObjectAndAPI.TestData;
using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Serialization.Json;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace BlueSkySeleniumSpecflowWaitsDataDrivenAssertionsPageObjectAndAPI.StepDefinitions
{
    [Binding]
    public class ApiTestsSteps
    {
        [Given(@"I have access to the url")]
        public void GivenIHaveAccessToTheUrl()
        {
            RestClient client = new RestClient("https://jsonplaceholder.typicode.com/users");

            RestRequest request = new RestRequest(Method.GET);

            // act
            IRestResponse response = client.Execute(request);


            //RestClient client = new RestClient("https://jsonplaceholder.typicode.com/users");
            //client.Timeout = -1;
            //RestRequest request = new RestRequest(Method.GET);
            //IRestResponse response = client.Execute(request);
            //Console.WriteLine(response.Content);

            //UserData userDetails1 = new JsonConvert.DeserializeObject<UserData>(response.Content);

            var userDetails = client.Execute<List<UserData>>(request);

            Assert.That(userDetails.Data[0].Address[0].street, Is.EqualTo("Kulas Light"));

        }


        public void twitter()
        {
            var client = new RestClient();
            //client.BaseUrl = "http://twitter.com";
            client.Authenticator = new HttpBasicAuthenticator("username", "password");

            var request = new RestRequest();
            request.Resource = "statuses/friends_timeline.xml";

            //RestResponse response = client.Execute(request);


            //var client = new RestClient("http://example.com");
            //client.Authenticator = new SimpleAuthenticator("username", "foo", "password", "bar");

            //var request = new RestRequest("resource", Method.GET);
            //client.Execute(request);
        }
    }
}
