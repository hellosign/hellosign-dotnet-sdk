using System.Net;
using RestSharp;
using Newtonsoft.Json;

namespace Org.HelloSign.Test
{
    public class MockRestClient : RestClient
    {
        private IRestResponse _response;

        private IRestRequest _request;

        public void SetExpectedResponse<T>(
            T data,
            HttpStatusCode statusCode,
            string contentType = "application/json"
        ) {
            IRestResponse<T> response = new RestResponse<T>();
            response.StatusCode = statusCode;
            response.ContentType = contentType;
            response.Data = data;
            response.Content = JsonConvert.SerializeObject(data);

            _response = response;
        }

        public IRestResponse GetResponse()
        {
            return _response;
        }

        public IRestRequest GetRequest()
        {
            return _request;
        }

        public string GetRequestContentType()
        {
            return _request.Parameters.Find(x =>
                x.Name == "Content-Type"
            ).Value?.ToString();
        }

        public void SetError(string error)
        {
            _response.ErrorMessage = error;
            _response.Content = error;
        }

        public override IRestResponse<T> Execute<T>(IRestRequest request)
        {
            _request = request;

            return _response as IRestResponse<T>;
        }
    }
}
