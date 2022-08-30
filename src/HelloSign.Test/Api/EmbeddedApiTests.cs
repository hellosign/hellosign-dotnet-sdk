using System.Net;
using Newtonsoft.Json.Linq;
using Xunit;

using HelloSign.Client;
using HelloSign.Api;
using HelloSign.Model;

namespace HelloSign.Test.Api
{
    public class EmbeddedApiTests
    {
        private readonly MockRestClient _mock;
        private readonly EmbeddedApi _api;

        public EmbeddedApiTests()
        {
            _mock = new MockRestClient();

            Configuration config = new Configuration();
            config.Username = "YOUR_API_KEY";

            var client = new ApiClient(config.BasePath, _mock);
            _api = new EmbeddedApi(client, client, config);
        }

        [Fact]
        public void EmbeddedEditUrlTest()
        {
            var templateId = "5de8179668f2033afac48da1868d0093bf133266";

            var requestData = TestHelper.SerializeFromFile<EmbeddedEditUrlRequest>("EmbeddedEditUrlRequest");
            var responseData = TestHelper.SerializeFromFile<EmbeddedEditUrlResponse>("EmbeddedEditUrlResponse");

            _mock.SetExpectedResponse(responseData, HttpStatusCode.Accepted);

            var response = _api.EmbeddedEditUrl(templateId, requestData);

            JToken.DeepEquals(
                responseData.ToJson(),
                response.ToJson()
            );
        }

        [Fact]
        public void EmbeddedSignUrlTest()
        {
            var signatureId = "50e3542f738adfa7ddd4cbd4c00d2a8ab6e4194b";

            var responseData = TestHelper.SerializeFromFile<EmbeddedSignUrlResponse>("EmbeddedSignUrlResponse");

            _mock.SetExpectedResponse(responseData, HttpStatusCode.Accepted);

            var response = _api.EmbeddedSignUrl(signatureId);

            JToken.DeepEquals(
                responseData.ToJson(),
                response.ToJson()
            );
        }
    }
}
