using System.Net;
using Newtonsoft.Json.Linq;
using Xunit;

using HelloSign.Client;
using HelloSign.Api;
using HelloSign.Model;

namespace HelloSign.Test.Api
{
    public class TeamApiTests
    {
        private readonly MockRestClient _mock;
        private readonly TeamApi _api;

        public TeamApiTests()
        {
            _mock = new MockRestClient();

            Configuration config = new Configuration();
            config.Username = "YOUR_API_KEY";

            var client = new ApiClient(config.BasePath, _mock);
            _api = new TeamApi(client, client, config);
        }

        [Fact]
        public void TeamAddMemberTest()
        {
            var requestData = TestHelper.SerializeFromFile<TeamAddMemberRequest>("TeamAddMemberRequest");
            var responseData = TestHelper.SerializeFromFile<TeamGetResponse>("TeamGetResponse");

            _mock.SetExpectedResponse(responseData, HttpStatusCode.Accepted);

            var response = _api.TeamAddMember(requestData);

            JToken.DeepEquals(
                responseData.ToJson(),
                response.ToJson()
            );
        }

        [Fact]
        public void TeamCreateTest()
        {
            var requestData = TestHelper.SerializeFromFile<TeamCreateRequest>("TeamCreateRequest");
            var responseData = TestHelper.SerializeFromFile<TeamGetResponse>("TeamGetResponse");

            _mock.SetExpectedResponse(responseData, HttpStatusCode.Accepted);

            var response = _api.TeamCreate(requestData);

            JToken.DeepEquals(
                responseData.ToJson(),
                response.ToJson()
            );
        }

        [Fact(Skip="DELETE /team/destroy skipped")]
        public void TeamDeleteTest()
        {
        }

        [Fact]
        public void TeamGetTest()
        {
            var responseData = TestHelper.SerializeFromFile<TeamGetResponse>("TeamGetResponse");

            _mock.SetExpectedResponse(responseData, HttpStatusCode.Accepted);

            var response = _api.TeamGet();

            JToken.DeepEquals(
                responseData.ToJson(),
                response.ToJson()
            );
        }

        [Fact]
        public void TeamUpdateTest()
        {
            var requestData = TestHelper.SerializeFromFile<TeamUpdateRequest>("TeamUpdateRequest");
            var responseData = TestHelper.SerializeFromFile<TeamGetResponse>("TeamGetResponse");

            _mock.SetExpectedResponse(responseData, HttpStatusCode.Accepted);

            var response = _api.TeamUpdate(requestData);

            JToken.DeepEquals(
                responseData.ToJson(),
                response.ToJson()
            );
        }

        [Fact]
        public void TeamRemoveTest()
        {
            var requestData = TestHelper.SerializeFromFile<TeamRemoveMemberRequest>("TeamRemoveMemberRequest");
            var responseData = TestHelper.SerializeFromFile<TeamGetResponse>("TeamGetResponse");

            _mock.SetExpectedResponse(responseData, HttpStatusCode.Accepted);

            var response = _api.TeamRemoveMember(requestData);

            JToken.DeepEquals(
                responseData.ToJson(),
                response.ToJson()
            );
        }
    }
}
