using Newtonsoft.Json.Linq;
using Xunit;

using HelloSign.Api;
using HelloSign.Model;

namespace HelloSign.Test.Api
{
    public class TeamApiTests
    {
        [Fact]
        public void TeamAddMemberTest()
        {
            var requestData = TestHelper.SerializeFromFile<TeamAddMemberRequest>("TeamAddMemberRequest");
            var responseData = TestHelper.SerializeFromFile<TeamGetResponse>("TeamGetResponse");

            var api = MockRestClientHelper.CreateApi<TeamGetResponse, TeamApi>(responseData);
            var response = api.TeamAddMember(requestData);

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

            var api = MockRestClientHelper.CreateApi<TeamGetResponse, TeamApi>(responseData);
            var response = api.TeamCreate(requestData);

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
            var api = MockRestClientHelper.CreateApi<TeamGetResponse, TeamApi>(responseData);

            var response = api.TeamGet();

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

            var api = MockRestClientHelper.CreateApi<TeamGetResponse, TeamApi>(responseData);

            var response = api.TeamUpdate(requestData);

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

            var api = MockRestClientHelper.CreateApi<TeamGetResponse, TeamApi>(responseData);

            var response = api.TeamRemoveMember(requestData);

            JToken.DeepEquals(
                responseData.ToJson(),
                response.ToJson()
            );
        }
    }
}