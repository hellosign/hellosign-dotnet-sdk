using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json.Linq;
using Xunit;

using HelloSign.Api;
using HelloSign.Model;

namespace HelloSign.Test.Api
{
    public class SignatureRequestApiTests
    {
        [Fact]
        public void SignatureRequestBulkCreateEmbeddedWithTemplateTest()
        {
            var requestData = TestHelper.SerializeFromFile<SignatureRequestBulkCreateEmbeddedWithTemplateRequest>("SignatureRequestBulkCreateEmbeddedWithTemplateRequest");
            var responseData = TestHelper.SerializeFromFile<BulkSendJobSendResponse>("BulkSendJobSendResponse");

            var api = MockRestClientHelper.CreateApi<BulkSendJobSendResponse, SignatureRequestApi>(responseData);

            requestData.SignerFile = new FileStream(
                TestHelper.RootPath + "/bulk-send-sample.csv",
                FileMode.Open,
                FileAccess.Read,
                FileShare.Read
            );

            var response = api.SignatureRequestBulkCreateEmbeddedWithTemplate(requestData);

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

            var api = MockRestClientHelper.CreateApi<BulkSendJobSendResponse, SignatureRequestApi>(responseData);

            requestData.SignerFile = new FileStream(
                TestHelper.RootPath + "/bulk-send-sample.csv",
                FileMode.Open,
                FileAccess.Read,
                FileShare.Read
            );

            var response = api.SignatureRequestBulkSendWithTemplate(requestData);

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

            var api = MockRestClientHelper.CreateApi<SignatureRequestGetResponse, SignatureRequestApi>(responseData);

            requestData.File = new List<Stream> {
                new FileStream(
                    TestHelper.RootPath + "/pdf-sample.pdf",
                    FileMode.Open,
                    FileAccess.Read,
                    FileShare.Read
                )
            };

            var response = api.SignatureRequestCreateEmbedded(requestData);

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

            var api = MockRestClientHelper.CreateApi<SignatureRequestGetResponse, SignatureRequestApi>(responseData);

            requestData.File = new List<Stream> {
                new FileStream(
                    TestHelper.RootPath + "/pdf-sample.pdf",
                    FileMode.Open,
                    FileAccess.Read,
                    FileShare.Read
                )
            };

            var response = api.SignatureRequestCreateEmbeddedWithTemplate(requestData);

            JToken.DeepEquals(
                responseData.ToJson(),
                response.ToJson()
            );
        }

        [Fact(Skip="GET /signature_request/files/{signature_request_id} skipped")]
        public void SignatureRequestFilesTest()
        {
        }

        [Fact]
        public void SignatureRequestGetTest()
        {
            var signatureRequestId = "fa5c8a0b0f492d768749333ad6fcc214c111e967";

            var responseData = TestHelper.SerializeFromFile<SignatureRequestGetResponse>("SignatureRequestGetResponse");

            var api = MockRestClientHelper.CreateApi<SignatureRequestGetResponse, SignatureRequestApi>(responseData);

            var response = api.SignatureRequestGet(signatureRequestId);

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

            var api = MockRestClientHelper.CreateApi<SignatureRequestListResponse, SignatureRequestApi>(responseData);

            var response = api.SignatureRequestList(accountId);

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

            var api = MockRestClientHelper.CreateApi<SignatureRequestGetResponse, SignatureRequestApi>(responseData);

            var response = api.SignatureRequestReleaseHold(signatureRequestId);

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

            var api = MockRestClientHelper.CreateApi<SignatureRequestGetResponse, SignatureRequestApi>(responseData);

            var response = api.SignatureRequestRemind(signatureRequestId, requestData);

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

            var api = MockRestClientHelper.CreateApi<SignatureRequestGetResponse, SignatureRequestApi>(responseData);

            requestData.File = new List<Stream> {
                new FileStream(
                    TestHelper.RootPath + "/pdf-sample.pdf",
                    FileMode.Open,
                    FileAccess.Read,
                    FileShare.Read
                )
            };

            var response = api.SignatureRequestSend(requestData);

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

            var api = MockRestClientHelper.CreateApi<SignatureRequestGetResponse, SignatureRequestApi>(responseData);

            var response = api.SignatureRequestSendWithTemplate(requestData);

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

            var api = MockRestClientHelper.CreateApi<SignatureRequestGetResponse, SignatureRequestApi>(responseData);

            var response = api.SignatureRequestUpdate(signatureRequestId, requestData);

            JToken.DeepEquals(
                responseData.ToJson(),
                response.ToJson()
            );
        }

        [Fact]
        public void FileForcesMultipartFormDataTest()
        {
            var requestData = TestHelper.SerializeFromFile<SignatureRequestSendRequest>("SignatureRequestSendRequest");
            var responseData = TestHelper.SerializeFromFile<SignatureRequestGetResponse>("SignatureRequestGetResponse");

            var api = MockRestClientHelper.CreateApiExpectMultiFormRequest<SignatureRequestGetResponse, SignatureRequestApi>(responseData);

            requestData.File = new List<Stream> {
                new FileStream(
                    TestHelper.RootPath + "/pdf-sample.pdf",
                    FileMode.Open,
                    FileAccess.Read,
                    FileShare.Read
                )
            };

            var response = api.SignatureRequestSend(requestData);

            JToken.DeepEquals(
                responseData.ToJson(),
                response.ToJson()
            );
        }

        [Fact]
        public void NoFileForcesJsonTest()
        {
            var requestData = TestHelper.SerializeFromFile<SignatureRequestSendRequest>("SignatureRequestSendRequest");
            var responseData = TestHelper.SerializeFromFile<SignatureRequestGetResponse>("SignatureRequestGetResponse");

            var api = MockRestClientHelper.CreateApiExpectJsonRequest<SignatureRequestGetResponse, SignatureRequestApi>(responseData);

            var response = api.SignatureRequestSend(requestData);

            JToken.DeepEquals(
                responseData.ToJson(),
                response.ToJson()
            );
        }
    }
}