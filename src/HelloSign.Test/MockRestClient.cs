using System.Net;
using RestSharp;
using Newtonsoft.Json;

namespace HelloSign.Test
{
    public class MockRestClient : RestClient
    {
        private RestResponse _response;

        private RestRequest _request;

        public void SetExpectedResponse<T>(
            T data,
            HttpStatusCode statusCode,
            string contentType = "application/json"
        ) {
            RestResponse<T> response = new RestResponse<T>();
            response.StatusCode = statusCode;
            response.ContentType = contentType;
            response.Data = data;
            response.Content = JsonConvert.SerializeObject(data);

            _response = response;
        }

        public RestResponse GetResponse()
        {
            return _response;
        }

        public RestRequest GetRequest()
        {
            return _request;
        }

        public string GetRequestContentType()
        {
            return _request.Parameters.TryFind("Content-Type")?.Value?.ToString();
            /*return _request.Parameters.Find(x =>
                x.Name == "Content-Type"
            ).Value?.ToString();*/
        }

        public void SetError(string error)
        {
            _response.ErrorMessage = error;
            _response.Content = error;
        }

        /*public override RestResponse<T> Execute<T>(RestRequest request)
        {
            _request = request;

            return _response as RestResponse;
        }*/
    }
}
