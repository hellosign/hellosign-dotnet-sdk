using Newtonsoft.Json.Linq;
using Xunit;

using HelloSign.Api;
using HelloSign.Model;

namespace HelloSign.Test.Api
{
    public class ReportApiTests
    {
        [Fact]
        public void ReportCreateTest()
        {
            var requestData = TestHelper.SerializeFromFile<ReportCreateRequest>("ReportCreateRequest");
            var responseData = TestHelper.SerializeFromFile<ReportCreateResponse>("ReportCreateResponse");

            var api = MockRestClientHelper.CreateApi<ReportCreateResponse, ReportApi>(responseData);

            var response = api.ReportCreate(requestData);

            JToken.DeepEquals(
                responseData.ToJson(),
                response.ToJson()
            );
        }
    }
}