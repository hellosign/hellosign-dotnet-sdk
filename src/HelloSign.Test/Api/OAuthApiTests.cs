using System.Net;
using Newtonsoft.Json.Linq;
using Xunit;

using HelloSign.Client;
using HelloSign.Api;
using HelloSign.Model;

namespace HelloSign.Test.Api
{
    public class OAuthApiTests
    {
        private readonly MockRestClient _mock;
        private readonly OAuthApi _api;

        public OAuthApiTests()
        {
            _mock = new MockRestClient();

            Configuration config = new Configuration();
            config.Username = "YOUR_API_KEY";

            var client = new ApiClient(config.BasePath, _mock);
            _api = new OAuthApi(client, client, config);
        }

        [Fact]
        public void TokenGenerateTest()
        {
            var requestData = TestHelper.SerializeFromFile<OAuthTokenGenerateRequest>("OAuthTokenGenerateRequest");
            var responseData = TestHelper.SerializeFromFile<OAuthTokenResponse>("OAuthTokenResponse");

            _mock.SetExpectedResponse(responseData, HttpStatusCode.Accepted);

            var response = _api.OauthTokenGenerate(requestData);

            JToken.DeepEquals(
                responseData.ToJson(),
                response.ToJson()
            );
        }

        [Fact]
        public void TokenRefreshTest()
        {
            var requestData = TestHelper.SerializeFromFile<OAuthTokenRefreshRequest>("OAuthTokenRefreshRequest");
            var responseData = TestHelper.SerializeFromFile<OAuthTokenResponse>("OAuthTokenResponse");

            _mock.SetExpectedResponse(responseData, HttpStatusCode.Accepted);

            var response = _api.OauthTokenRefresh(requestData);

            JToken.DeepEquals(
                responseData.ToJson(),
                response.ToJson()
            );
        }
    }
}
