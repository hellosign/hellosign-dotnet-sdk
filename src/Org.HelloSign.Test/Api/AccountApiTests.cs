using System.Net;
using Newtonsoft.Json.Linq;
using Xunit;

using Org.HelloSign.Client;
using Org.HelloSign.Api;
using Org.HelloSign.Model;

namespace Org.HelloSign.Test.Api
{
    public class AccountApiTests
    {
        private readonly MockRestClient _mock;
        private readonly AccountApi _api;

        public AccountApiTests()
        {
            _mock = new MockRestClient();

            Configuration config = new Configuration();
            config.Username = "YOUR_API_KEY";

            var client = new ApiClient(config.BasePath, _mock);
            _api = new AccountApi(client, client, config);
        }

        [Fact]
        public void HttpCodeRangeTest()
        {
            var requestData = TestHelper.SerializeFromFile<AccountVerifyRequest>("AccountVerifyRequest");
            var responseData = TestHelper.SerializeFromFile<AccountVerifyResponse>("AccountVerifyResponse");
            var errorData = TestHelper.SerializeFromFile<ErrorResponse>("ErrorResponse");

            _mock.SetExpectedResponse<AccountVerifyResponse>(responseData, HttpStatusCode.BadRequest);
            _mock.SetError(errorData.ToJson());

            var ex = Assert.Throws<ApiException>(() =>
                _api.AccountVerify(requestData)
            );

            JToken.DeepEquals(
                responseData.ToJson(),
                ex.ErrorContent.ToJson()
            );
        }

        [Fact]
        public void AccountCreateTest()
        {
            var requestData = TestHelper.SerializeFromFile<AccountCreateRequest>("AccountCreateRequest");
            var responseData = TestHelper.SerializeFromFile<AccountCreateResponse>("AccountCreateResponse");

            _mock.SetExpectedResponse(responseData, HttpStatusCode.Accepted);

            var response = _api.AccountCreate(requestData);

            JToken.DeepEquals(
                responseData.ToJson(),
                response.ToJson()
            );
        }

        [Fact]
        public void AccountGetTest()
        {
            var responseData = TestHelper.SerializeFromFile<AccountGetResponse>("AccountGetResponse");

            _mock.SetExpectedResponse(responseData, HttpStatusCode.Accepted);

            var response = _api.AccountGet();

            JToken.DeepEquals(
                responseData.ToJson(),
                response.ToJson()
            );
        }

        [Fact]
        public void AccountUpdateTest()
        {
            var requestData = TestHelper.SerializeFromFile<AccountUpdateRequest>("AccountUpdateRequest");
            var responseData = TestHelper.SerializeFromFile<AccountGetResponse>("AccountGetResponse");

            _mock.SetExpectedResponse(responseData, HttpStatusCode.Accepted);

            var response = _api.AccountUpdate(requestData);

            JToken.DeepEquals(
                responseData.ToJson(),
                response.ToJson()
            );
        }

        [Fact]
        public void AccountVerifyTest()
        {
            var requestData = TestHelper.SerializeFromFile<AccountVerifyRequest>("AccountVerifyRequest");
            var responseData = TestHelper.SerializeFromFile<AccountVerifyResponse>("AccountVerifyResponse");

            _mock.SetExpectedResponse(responseData, HttpStatusCode.Accepted);

            var response = _api.AccountVerify(requestData);

            JToken.DeepEquals(
                responseData.ToJson(),
                response.ToJson()
            );
        }
    }
}
