using Newtonsoft.Json.Linq;
using Xunit;

using HelloSign.Api;
using HelloSign.Model;

namespace HelloSign.Test.Api
{
    public class EmbeddedApiTests
    {
        [Fact]
        public void EmbeddedEditUrlTest()
        {
            var templateId = "5de8179668f2033afac48da1868d0093bf133266";

            var requestData = TestHelper.SerializeFromFile<EmbeddedEditUrlRequest>("EmbeddedEditUrlRequest");
            var responseData = TestHelper.SerializeFromFile<EmbeddedEditUrlResponse>("EmbeddedEditUrlResponse");

            var api = MockRestClientHelper.CreateApi<EmbeddedEditUrlResponse, EmbeddedApi>(responseData);

            var response = api.EmbeddedEditUrl(templateId, requestData);

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

            var api = MockRestClientHelper.CreateApi<EmbeddedSignUrlResponse, EmbeddedApi>(responseData);

            var response = api.EmbeddedSignUrl(signatureId);

            JToken.DeepEquals(
                responseData.ToJson(),
                response.ToJson()
            );
        }
    }
}