using System.Net;
using Newtonsoft.Json.Linq;
using Xunit;

using HelloSign.Client;
using HelloSign.Api;
using HelloSign.Model;

namespace HelloSign.Test.Api
{
    public class AccountApiTests
    {
        [Fact]
        public void HttpCodeRangeTest()
        {
            var requestData = TestHelper.SerializeFromFile<AccountVerifyRequest>("AccountVerifyRequest");
            var responseData = TestHelper.SerializeFromFile<AccountVerifyResponse>("AccountVerifyResponse");
            var errorData = TestHelper.SerializeFromFile<ErrorResponse>("ErrorResponse");

            var api = MockRestClientHelper.CreateApi<ErrorResponse, AccountApi>(errorData, HttpStatusCode.BadRequest);

            var ex = Assert.Throws<ApiException>(() =>
                api.AccountVerify(requestData)
            );

            JToken.DeepEquals(
                responseData.ToJson(),
                ex.ErrorContent.ToString()
            );
        }

        [Fact]
        public void AccountCreateTest()
        {
            var requestData = TestHelper.SerializeFromFile<AccountCreateRequest>("AccountCreateRequest");
            var responseData = TestHelper.SerializeFromFile<AccountCreateResponse>("AccountCreateResponse");

            var api = MockRestClientHelper.CreateApi<AccountCreateResponse, AccountApi>(responseData);

            var response = api.AccountCreate(requestData);

            JToken.DeepEquals(
                responseData.ToJson(),
                response.ToJson()
            );
        }

        [Fact]
        public void AccountGetTest()
        {
            var responseData = TestHelper.SerializeFromFile<AccountGetResponse>("AccountGetResponse");

            var api = MockRestClientHelper.CreateApi<AccountGetResponse, AccountApi>(responseData);

            var response = api.AccountGet(null, "jack@example.com");

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

            var api = MockRestClientHelper.CreateApi<AccountGetResponse, AccountApi>(responseData);

            var response = api.AccountUpdate(requestData);

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

            var api = MockRestClientHelper.CreateApi<AccountVerifyResponse, AccountApi>(responseData);

            var response = api.AccountVerify(requestData);

            JToken.DeepEquals(
                responseData.ToJson(),
                response.ToJson()
            );
        }
    }
}