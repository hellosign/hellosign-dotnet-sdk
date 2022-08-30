using System.Net;
using Newtonsoft.Json.Linq;
using Xunit;

using HelloSign.Client;
using HelloSign.Api;
using HelloSign.Model;

namespace HelloSign.Test.Api
{
    public class BulkSendJobApiTests
    {
        private readonly MockRestClient _mock;
        private readonly BulkSendJobApi _api;

        public BulkSendJobApiTests()
        {
            _mock = new MockRestClient();

            Configuration config = new Configuration();
            config.Username = "YOUR_API_KEY";

            var client = new ApiClient(config.BasePath, _mock);
            _api = new BulkSendJobApi(client, client, config);
        }

        [Fact]
        public void BulkSendJobGetTest()
        {
            var id = "6e683bc0369ba3d5b6f43c2c22a8031dbf6bd174";

            var responseData = TestHelper.SerializeFromFile<BulkSendJobGetResponse>("BulkSendJobGetResponse");

            _mock.SetExpectedResponse(responseData, HttpStatusCode.Accepted);

            var response = _api.BulkSendJobGet(id);

            JToken.DeepEquals(
                responseData.ToJson(),
                response.ToJson()
            );
        }

        [Fact]
        public void BulkSendJobListTest()
        {
            var page = 1;
            var pageSize = 2;

            var responseData = TestHelper.SerializeFromFile<BulkSendJobListResponse>("BulkSendJobListResponse");

            _mock.SetExpectedResponse(responseData, HttpStatusCode.Accepted);

            var response = _api.BulkSendJobList(page, pageSize);

            JToken.DeepEquals(
                responseData.ToJson(),
                response.ToJson()
            );
        }
    }
}
