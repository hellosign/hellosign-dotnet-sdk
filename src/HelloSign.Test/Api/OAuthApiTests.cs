using Newtonsoft.Json.Linq;
using Xunit;

using HelloSign.Api;
using HelloSign.Model;

namespace HelloSign.Test.Api
{
    public class OAuthApiTests
    {
        [Fact]
        public void TokenGenerateTest()
        {
            var requestData = TestHelper.SerializeFromFile<OAuthTokenGenerateRequest>("OAuthTokenGenerateRequest");
            var responseData = TestHelper.SerializeFromFile<OAuthTokenResponse>("OAuthTokenResponse");

            var api = MockRestClientHelper.CreateApi<OAuthTokenResponse, OAuthApi>(responseData);

            var response = api.OauthTokenGenerate(requestData);

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

            var api = MockRestClientHelper.CreateApi<OAuthTokenResponse, OAuthApi>(responseData);

            var response = api.OauthTokenRefresh(requestData);

            JToken.DeepEquals(
                responseData.ToJson(),
                response.ToJson()
            );
        }
    }
}