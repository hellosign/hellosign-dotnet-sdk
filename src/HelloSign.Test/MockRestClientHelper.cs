using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using HelloSign.Client;
using RestSharp;
using Newtonsoft.Json;
using RichardSzalay.MockHttp;

namespace HelloSign.Test
{
    public class MockRestClientHelper 
    {
        public static T CreateApi<S, T>(S data, 
            HttpStatusCode statusCode = HttpStatusCode.Accepted,
            string contentType = "application/json")
        {
            var mockHttp = new MockHttpMessageHandler();
            
            mockHttp.Expect("https://api.hellosign.com/*")
                .Respond(statusCode, contentType, JsonConvert.SerializeObject(data));

            return CreateApiInternal<T>(mockHttp);
        }
        
        public static T CreateApiExpectMultiFormRequest<S, T>(S data, 
            HttpStatusCode statusCode = HttpStatusCode.Accepted,
            string contentType = "application/json")
        {
            var mockHttp = new MockHttpMessageHandler();
            
            mockHttp.Expect("https://api.hellosign.com/*")
                .With(request => request.Content.GetType() == typeof(MultipartFormDataContent))
                .Respond(statusCode, contentType, JsonConvert.SerializeObject(data));
            
            return CreateApiInternal<T>(mockHttp);
        }
        
        public static T CreateApiExpectJsonRequest<S, T>(S data, 
            HttpStatusCode statusCode = HttpStatusCode.Accepted,
            string contentType = "application/json")
        {
            var mockHttp = new MockHttpMessageHandler();
            
            mockHttp.Expect("https://api.hellosign.com/*")
                .With(request => request.Content.GetType() == typeof(StringContent))
                .Respond(statusCode, contentType, JsonConvert.SerializeObject(data));
            
            return CreateApiInternal<T>(mockHttp);
        }
        
        public static T CreateApiExpectContentContains<S, T>(S data, 
            HttpStatusCode statusCode = HttpStatusCode.Accepted,
            string contentType = "application/json", params string[] values)
        {
            var mockHttp = new MockHttpMessageHandler();
            mockHttp.Expect("https://api.hellosign.com/*")
                .With(request =>
                {
                    var stream = request.Content.ReadAsStream();
                    var streamReader = new StreamReader( stream );
                    var content = streamReader.ReadToEnd();
                    return values.All(value => content.Contains(value));
                })
                .Respond(statusCode, contentType, JsonConvert.SerializeObject(data));

            return CreateApiInternal<T>(mockHttp);
        }
        
        private static T CreateApiInternal<T>(MockHttpMessageHandler handler)
        {
            var options = new RestClientOptions
            {
                ConfigureMessageHandler = _ => handler,
                BaseUrl = new Uri("https://api.hellosign.com")
            };
            var mockRestClient = new RestClient(options);
            Configuration config = new Configuration();
            config.Username = "YOUR_API_KEY";
            var client = new ApiClient(config.BasePath, mockRestClient);
            return (T)Activator.CreateInstance(typeof(T), client, client, config);
        }
    }
}
