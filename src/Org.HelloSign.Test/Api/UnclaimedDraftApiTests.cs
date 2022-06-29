using System.Net;
using Newtonsoft.Json.Linq;
using Xunit;

using Org.HelloSign.Client;
using Org.HelloSign.Api;
using Org.HelloSign.Model;

namespace Org.HelloSign.Test.Api
{
    public class UnclaimedDraftApiTests
    {
        private readonly MockRestClient _mock;
        private readonly UnclaimedDraftApi _api;

        public UnclaimedDraftApiTests()
        {
            _mock = new MockRestClient();

            Configuration config = new Configuration();
            config.Username = "YOUR_API_KEY";

            var client = new ApiClient(config.BasePath, _mock);
            _api = new UnclaimedDraftApi(client, client, config);
        }

        [Fact]
        public void UnclaimedDraftCreateTest()
        {
            var requestData = TestHelper.SerializeFromFile<UnclaimedDraftCreateRequest>("UnclaimedDraftCreateRequest");
            var responseData = TestHelper.SerializeFromFile<UnclaimedDraftCreateResponse>("UnclaimedDraftCreateResponse");

            _mock.SetExpectedResponse(responseData, HttpStatusCode.Accepted);

            var response = _api.UnclaimedDraftCreate(requestData);

            JToken.DeepEquals(
                responseData.ToJson(),
                response.ToJson()
            );
        }

        [Fact]
        public void UnclaimedDraftCreateEmbeddedTest()
        {
            var requestData = TestHelper.SerializeFromFile<UnclaimedDraftCreateEmbeddedRequest>("UnclaimedDraftCreateEmbeddedRequest");
            var responseData = TestHelper.SerializeFromFile<UnclaimedDraftCreateResponse>("UnclaimedDraftCreateResponse");

            _mock.SetExpectedResponse(responseData, HttpStatusCode.Accepted);

            var response = _api.UnclaimedDraftCreateEmbedded(requestData);

            JToken.DeepEquals(
                responseData.ToJson(),
                response.ToJson()
            );
        }

        [Fact]
        public void UnclaimedDraftCreateEmbeddedWithTemplateTest()
        {
            var requestData = TestHelper.SerializeFromFile<UnclaimedDraftCreateEmbeddedWithTemplateRequest>("UnclaimedDraftCreateEmbeddedWithTemplateRequest");
            var responseData = TestHelper.SerializeFromFile<UnclaimedDraftCreateResponse>("UnclaimedDraftCreateResponse");

            _mock.SetExpectedResponse(responseData, HttpStatusCode.Accepted);

            var response = _api.UnclaimedDraftCreateEmbeddedWithTemplate(requestData);

            JToken.DeepEquals(
                responseData.ToJson(),
                response.ToJson()
            );
        }

        [Fact]
        public void UnclaimedDraftEditAndResendTest()
        {
            var signatureRequestId = "2f9781e1a83jdja934d808c153c2e1d3df6f8f2f";

            var requestData = TestHelper.SerializeFromFile<UnclaimedDraftEditAndResendRequest>("UnclaimedDraftEditAndResendRequest");
            var responseData = TestHelper.SerializeFromFile<UnclaimedDraftCreateResponse>("UnclaimedDraftCreateResponse");

            _mock.SetExpectedResponse(responseData, HttpStatusCode.Accepted);

            var response = _api.UnclaimedDraftEditAndResend(signatureRequestId, requestData);

            JToken.DeepEquals(
                responseData.ToJson(),
                response.ToJson()
            );
        }
    }
}
