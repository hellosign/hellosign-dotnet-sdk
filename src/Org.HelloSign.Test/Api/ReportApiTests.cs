using System.Net;
using Newtonsoft.Json.Linq;
using Xunit;

using Org.HelloSign.Client;
using Org.HelloSign.Api;
using Org.HelloSign.Model;

namespace Org.HelloSign.Test.Api
{
    public class ReportApiTests
    {
        private readonly MockRestClient _mock;
        private readonly ReportApi _api;

        public ReportApiTests()
        {
            _mock = new MockRestClient();

            Configuration config = new Configuration();
            config.Username = "YOUR_API_KEY";

            var client = new ApiClient(config.BasePath, _mock);
            _api = new ReportApi(client, client, config);
        }

        [Fact]
        public void ReportCreateTest()
        {
            var requestData = TestHelper.SerializeFromFile<ReportCreateRequest>("ReportCreateRequest");
            var responseData = TestHelper.SerializeFromFile<ReportCreateResponse>("ReportCreateResponse");

            _mock.SetExpectedResponse(responseData, HttpStatusCode.Accepted);

            var response = _api.ReportCreate(requestData);

            JToken.DeepEquals(
                responseData.ToJson(),
                response.ToJson()
            );
        }
    }
}
