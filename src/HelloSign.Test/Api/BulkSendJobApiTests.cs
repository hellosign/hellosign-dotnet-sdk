using Newtonsoft.Json.Linq;
using Xunit;

using HelloSign.Api;
using HelloSign.Model;

namespace HelloSign.Test.Api
{
    public class BulkSendJobApiTests
    {
        [Fact]
        public void BulkSendJobGetTest()
        {
            var id = "6e683bc0369ba3d5b6f43c2c22a8031dbf6bd174";

            var responseData = TestHelper.SerializeFromFile<BulkSendJobGetResponse>("BulkSendJobGetResponse");

            var api = MockRestClientHelper.CreateApi<BulkSendJobGetResponse, BulkSendJobApi>(responseData);

            var response = api.BulkSendJobGet(id);

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

            var api = MockRestClientHelper.CreateApi<BulkSendJobListResponse, BulkSendJobApi>(responseData);

            var response = api.BulkSendJobList(page, pageSize);

            JToken.DeepEquals(
                responseData.ToJson(),
                response.ToJson()
            );
        }
    }
}