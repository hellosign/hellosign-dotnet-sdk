using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json.Linq;
using Xunit;

using Org.HelloSign.Client;
using Org.HelloSign.Api;
using Org.HelloSign.Model;

namespace Org.HelloSign.Test.Api
{
    public class ApiAppApiTests
    {
        private readonly MockRestClient _mock;
        private readonly ApiAppApi _api;

        public ApiAppApiTests()
        {
            _mock = new MockRestClient();

            Configuration config = new Configuration();
            config.Username = "YOUR_API_KEY";

            var client = new ApiClient(config.BasePath, _mock);
            _api = new ApiAppApi(client, client, config);
        }

        [Fact]
        public void ApiAppCreateTest()
        {
            var requestData = TestHelper.SerializeFromFile<ApiAppCreateRequest>("ApiAppCreateRequest");
            var responseData = TestHelper.SerializeFromFile<ApiAppGetResponse>("ApiAppGetResponse");

            _mock.SetExpectedResponse(responseData, HttpStatusCode.Accepted);

            var response = _api.ApiAppCreate(requestData);

            JToken.DeepEquals(
                responseData.ToJson(),
                response.ToJson()
            );
        }

        [Fact]
        public void ApiAppGetTest()
        {
            var clientId = "0dd3b823a682527788c4e40cb7b6f7e9";

            var responseData = TestHelper.SerializeFromFile<ApiAppGetResponse>("ApiAppGetResponse");

            _mock.SetExpectedResponse(responseData, HttpStatusCode.Accepted);

            var response = _api.ApiAppGet(clientId);

            JToken.DeepEquals(
                responseData.ToJson(),
                response.ToJson()
            );
        }

        [Fact]
        public void ApiAppUpdateTest()
        {
            var clientId = "0dd3b823a682527788c4e40cb7b6f7e9";

            var requestData = TestHelper.SerializeFromFile<ApiAppUpdateRequest>("ApiAppUpdateRequest");
            var responseData = TestHelper.SerializeFromFile<ApiAppGetResponse>("ApiAppGetResponse");

            _mock.SetExpectedResponse(responseData, HttpStatusCode.Accepted);

            var response = _api.ApiAppUpdate(clientId, requestData);

            JToken.DeepEquals(
                responseData.ToJson(),
                response.ToJson()
            );
        }

        [Fact(Skip="DELETE /api_app/{client_id} skipped")]
        public void ApiAppDeleteTest()
        {
        }

        [Fact]
        public void ApiAppListTest()
        {
            var page = 1;
            var pageSize = 20;

            var responseData = TestHelper.SerializeFromFile<ApiAppListResponse>("ApiAppListResponse");

            _mock.SetExpectedResponse(responseData, HttpStatusCode.Accepted);

            var response = _api.ApiAppList(page, pageSize);

            JToken.DeepEquals(
                responseData.ToJson(),
                response.ToJson()
            );
        }

        [Fact]
        public void ValusJsonifiedTest()
        {
            var oauth = new SubOAuth(
                callbackUrl: "https://oauth-callback.test",
                scopes: new List<SubOAuth.ScopesEnum>() {SubOAuth.ScopesEnum.TemplateAccess}
            );

            var customLogoFile = TestHelper.GetFile("pdf-sample.pdf");

            var obj = new ApiAppCreateRequest(
                name: "My name is",
                callbackUrl: "https://awesome.test",
                domains: new List<string>() {"domain1.com", "domain2.com"},
                oauth: oauth,
                customLogoFile: customLogoFile
            );

            var responseData = TestHelper.SerializeFromFile<ApiAppGetResponse>("ApiAppGetResponse");
            _mock.SetExpectedResponse(responseData, HttpStatusCode.Accepted);

            var response = _api.ApiAppCreate(obj);

            var lastRequest = _mock.GetRequest();

            var resultDomains = lastRequest.Parameters.Find(x =>
                x.Name == "domains"
            ).Value?.ToString();

            var resultName = lastRequest.Parameters.Find(x =>
                x.Name == "name"
            ).Value?.ToString();

            var resultOauth = lastRequest.Parameters.Find(x =>
                x.Name == "oauth"
            ).Value?.ToString();

            Assert.Equal("[\"domain1.com\",\"domain2.com\"]", resultDomains);
            Assert.Equal("My name is", resultName);
            Assert.Equal("{\"scopes\":[\"template_access\"],\"callback_url\":\"https://oauth-callback.test\"}", resultOauth);
        }
    }
}
