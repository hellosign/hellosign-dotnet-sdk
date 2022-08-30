using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json.Linq;
using Xunit;

using HelloSign.Client;
using HelloSign.Api;
using HelloSign.Model;

namespace HelloSign.Test.Api
{
    public class SignatureRequestApiTests
    {
        private readonly MockRestClient _mock;
        private readonly SignatureRequestApi _api;

        public SignatureRequestApiTests()
        {
            _mock = new MockRestClient();

            Configuration config = new Configuration();
            config.Username = "YOUR_API_KEY";

            var client = new ApiClient(config.BasePath, _mock);
            _api = new SignatureRequestApi(client, client, config);
        }

        [Fact]
        public void SignatureRequestBulkCreateEmbeddedWithTemplateTest()
        {
            var requestData = TestHelper.SerializeFromFile<SignatureRequestBulkCreateEmbeddedWithTemplateRequest>("SignatureRequestBulkCreateEmbeddedWithTemplateRequest");
            var responseData = TestHelper.SerializeFromFile<BulkSendJobSendResponse>("BulkSendJobSendResponse");

            _mock.SetExpectedResponse(responseData, HttpStatusCode.Accepted);

            var response = _api.SignatureRequestBulkCreateEmbeddedWithTemplate(requestData);

            JToken.DeepEquals(
                responseData.ToJson(),
                response.ToJson()
            );
        }

        [Fact]
        public void SignatureRequestBulkSendWithTemplateTest()
        {
            var requestData = TestHelper.SerializeFromFile<SignatureRequestBulkSendWithTemplateRequest>("SignatureRequestBulkSendWithTemplateRequest");
            var responseData = TestHelper.SerializeFromFile<BulkSendJobSendResponse>("BulkSendJobSendResponse");

            _mock.SetExpectedResponse(responseData, HttpStatusCode.Accepted);

            var response = _api.SignatureRequestBulkSendWithTemplate(requestData);

            JToken.DeepEquals(
                responseData.ToJson(),
                response.ToJson()
            );
        }

        [Fact(Skip="POST /signature_request/cancel/{signature_request_id} skipped")]
        public void SignatureRequestCancelTest()
        {
        }

        [Fact]
        public void SignatureRequestCreateEmbeddedTest()
        {
            var requestData = TestHelper.SerializeFromFile<SignatureRequestCreateEmbeddedRequest>("SignatureRequestCreateEmbeddedRequest");
            var responseData = TestHelper.SerializeFromFile<SignatureRequestGetResponse>("SignatureRequestGetResponse");

            _mock.SetExpectedResponse(responseData, HttpStatusCode.Accepted);

            var response = _api.SignatureRequestCreateEmbedded(requestData);

            JToken.DeepEquals(
                responseData.ToJson(),
                response.ToJson()
            );
        }

        [Fact]
        public void SignatureRequestCreateEmbeddedWithTemplateTest()
        {
            var requestData = TestHelper.SerializeFromFile<SignatureRequestCreateEmbeddedWithTemplateRequest>("SignatureRequestCreateEmbeddedWithTemplateRequest");
            var responseData = TestHelper.SerializeFromFile<SignatureRequestGetResponse>("SignatureRequestGetResponse");

            _mock.SetExpectedResponse(responseData, HttpStatusCode.Accepted);

            var response = _api.SignatureRequestCreateEmbeddedWithTemplate(requestData);

            JToken.DeepEquals(
                responseData.ToJson(),
                response.ToJson()
            );
        }

        [Fact]
        public void SignatureRequestFilesTest()
        {
            var templateId = "f57db65d3f933b5316d398057a36176831451a35";
            var fileType = "pdf";
            var getUrl = false;
            var getDataUri = false;

            var responseData = TestHelper.SerializeFromFile<FileResponse>("FileResponse");

            _mock.SetExpectedResponse(responseData, HttpStatusCode.Accepted);

            var response = _api.SignatureRequestFiles(
                templateId,
                fileType,
                getUrl,
                getDataUri
            );

            JToken.DeepEquals(
                responseData.ToJson(),
                response.ToJson()
            );
        }

        [Fact]
        public void SignatureRequestGetTest()
        {
            var signatureRequestId = "fa5c8a0b0f492d768749333ad6fcc214c111e967";

            var responseData = TestHelper.SerializeFromFile<SignatureRequestGetResponse>("SignatureRequestGetResponse");

            _mock.SetExpectedResponse(responseData, HttpStatusCode.Accepted);

            var response = _api.SignatureRequestGet(signatureRequestId);

            JToken.DeepEquals(
                responseData.ToJson(),
                response.ToJson()
            );
        }

        [Fact]
        public void SignatureRequestListTest()
        {
            var accountId = "all";

            var responseData = TestHelper.SerializeFromFile<SignatureRequestListResponse>("SignatureRequestListResponse");

            _mock.SetExpectedResponse(responseData, HttpStatusCode.Accepted);

            var response = _api.SignatureRequestList(accountId);

            JToken.DeepEquals(
                responseData.ToJson(),
                response.ToJson()
            );
        }

        [Fact]
        public void SignatureRequestReleaseHoldTest()
        {
            var signatureRequestId = "fa5c8a0b0f492d768749333ad6fcc214c111e967";

            var responseData = TestHelper.SerializeFromFile<SignatureRequestGetResponse>("SignatureRequestGetResponse");

            _mock.SetExpectedResponse(responseData, HttpStatusCode.Accepted);

            var response = _api.SignatureRequestReleaseHold(signatureRequestId);

            JToken.DeepEquals(
                responseData.ToJson(),
                response.ToJson()
            );
        }

        [Fact]
        public void SignatureRequestRemindTest()
        {
            var signatureRequestId = "fa5c8a0b0f492d768749333ad6fcc214c111e967";

            var requestData = TestHelper.SerializeFromFile<SignatureRequestRemindRequest>("SignatureRequestRemindRequest");
            var responseData = TestHelper.SerializeFromFile<SignatureRequestGetResponse>("SignatureRequestGetResponse");

            _mock.SetExpectedResponse(responseData, HttpStatusCode.Accepted);

            var response = _api.SignatureRequestRemind(signatureRequestId, requestData);

            JToken.DeepEquals(
                responseData.ToJson(),
                response.ToJson()
            );
        }

        [Fact(Skip="POST /signature_request/remove/{signature_request_id} skipped")]
        public void SignatureRequestRemoveTest()
        {
        }

        [Fact]
        public void SignatureRequestSendTest()
        {
            var requestData = TestHelper.SerializeFromFile<SignatureRequestSendRequest>("SignatureRequestSendRequest");
            var responseData = TestHelper.SerializeFromFile<SignatureRequestGetResponse>("SignatureRequestGetResponse");

            _mock.SetExpectedResponse(responseData, HttpStatusCode.Accepted);

            var response = _api.SignatureRequestSend(requestData);

            JToken.DeepEquals(
                responseData.ToJson(),
                response.ToJson()
            );
        }

        [Fact]
        public void SignatureRequestSendWithTemplateTest()
        {
            var requestData = TestHelper.SerializeFromFile<SignatureRequestSendWithTemplateRequest>("SignatureRequestSendWithTemplateRequest");
            var responseData = TestHelper.SerializeFromFile<SignatureRequestGetResponse>("SignatureRequestGetResponse");

            _mock.SetExpectedResponse(responseData, HttpStatusCode.Accepted);

            var response = _api.SignatureRequestSendWithTemplate(requestData);

            JToken.DeepEquals(
                responseData.ToJson(),
                response.ToJson()
            );
        }

        [Fact]
        public void SignatureRequestUpdateTest()
        {
            var signatureRequestId = "fa5c8a0b0f492d768749333ad6fcc214c111e967";

            var requestData = TestHelper.SerializeFromFile<SignatureRequestUpdateRequest>("SignatureRequestUpdateRequest");
            var responseData = TestHelper.SerializeFromFile<SignatureRequestGetResponse>("SignatureRequestGetResponse");

            _mock.SetExpectedResponse(responseData, HttpStatusCode.Accepted);

            var response = _api.SignatureRequestUpdate(signatureRequestId, requestData);

            JToken.DeepEquals(
                responseData.ToJson(),
                response.ToJson()
            );
        }

        [Fact]
        public void MultipleFilesInstantiatedTest()
        {
            var requestData = TestHelper.SerializeFromFile<SignatureRequestSendRequest>("SignatureRequestSendRequest");

            Assert.IsType<List<System.IO.Stream>>(requestData.File);
            Assert.NotEmpty(requestData.File);
        }

        [Fact]
        public void FileForcesMultipartFormDataTest()
        {
            var requestData = TestHelper.SerializeFromFile<SignatureRequestSendRequest>("SignatureRequestSendRequest", "with_file");
            var responseData = TestHelper.SerializeFromFile<SignatureRequestGetResponse>("SignatureRequestGetResponse");

            _mock.SetExpectedResponse(responseData, HttpStatusCode.Accepted);

            var response = _api.SignatureRequestSend(requestData);

            Assert.Equal("multipart/form-data", _mock.GetRequestContentType());
        }

        [Fact]
        public void NoFileForcesJsonTest()
        {
            var requestData = TestHelper.SerializeFromFile<SignatureRequestSendRequest>("SignatureRequestSendRequest", "with_file_url");
            var responseData = TestHelper.SerializeFromFile<SignatureRequestGetResponse>("SignatureRequestGetResponse");

            _mock.SetExpectedResponse(responseData, HttpStatusCode.Accepted);

            var response = _api.SignatureRequestSend(requestData);

            Assert.Equal("application/json", _mock.GetRequestContentType());
        }
    }
}
