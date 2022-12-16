using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json.Linq;
using Xunit;

using HelloSign.Api;
using HelloSign.Model;

namespace HelloSign.Test.Api
{
    public class UnclaimedDraftApiTests
    {
        [Fact]
        public void UnclaimedDraftCreateTest()
        {
            var requestData = TestHelper.SerializeFromFile<UnclaimedDraftCreateRequest>("UnclaimedDraftCreateRequest");
            var responseData = TestHelper.SerializeFromFile<UnclaimedDraftCreateResponse>("UnclaimedDraftCreateResponse");

            var api = MockRestClientHelper.CreateApi<UnclaimedDraftCreateResponse, UnclaimedDraftApi>(responseData);

            var response = api.UnclaimedDraftCreate(requestData);

            JToken.DeepEquals(
                responseData.ToJson(),
                response.ToJson()
            );
        }

        [Fact]
        public void UnclaimedDraftCreateEmbeddedTest()
        {
            var requestData = TestHelper.SerializeFromFile<UnclaimedDraftCreateEmbeddedRequest>("UnclaimedDraftCreateEmbeddedRequest");
            var responseData = TestHelper.SerializeFromFile<UnclaimedDraftCreateResponse>("UnclaimedDraftCreateResponse");

            var api = MockRestClientHelper.CreateApi<UnclaimedDraftCreateResponse, UnclaimedDraftApi>(responseData);

            requestData.File = new List<Stream> {
                new FileStream(
                    TestHelper.RootPath + "/pdf-sample.pdf",
                    FileMode.Open,
                    FileAccess.Read,
                    FileShare.Read
                )
            };

            var response = api.UnclaimedDraftCreateEmbedded(requestData);

            JToken.DeepEquals(
                responseData.ToJson(),
                response.ToJson()
            );
        }

        [Fact]
        public void UnclaimedDraftCreateEmbeddedWithTemplateTest()
        {
            var requestData = TestHelper.SerializeFromFile<UnclaimedDraftCreateEmbeddedWithTemplateRequest>("UnclaimedDraftCreateEmbeddedWithTemplateRequest");
            var responseData = TestHelper.SerializeFromFile<UnclaimedDraftCreateResponse>("UnclaimedDraftCreateResponse");

            var api = MockRestClientHelper.CreateApi<UnclaimedDraftCreateResponse, UnclaimedDraftApi>(responseData);

            requestData.File = new List<Stream> {
                new FileStream(
                    TestHelper.RootPath + "/pdf-sample.pdf",
                    FileMode.Open,
                    FileAccess.Read,
                    FileShare.Read
                )
            };

            var response = api.UnclaimedDraftCreateEmbeddedWithTemplate(requestData);

            JToken.DeepEquals(
                responseData.ToJson(),
                response.ToJson()
            );
        }

        [Fact]
        public void UnclaimedDraftEditAndResendTest()
        {
            var signatureRequestId = "2f9781e1a83jdja934d808c153c2e1d3df6f8f2f";

            var requestData = TestHelper.SerializeFromFile<UnclaimedDraftEditAndResendRequest>("UnclaimedDraftEditAndResendRequest");
            var responseData = TestHelper.SerializeFromFile<UnclaimedDraftCreateResponse>("UnclaimedDraftCreateResponse");

            var api = MockRestClientHelper.CreateApi<UnclaimedDraftCreateResponse, UnclaimedDraftApi>(responseData);

            var response = api.UnclaimedDraftEditAndResend(signatureRequestId, requestData);

            JToken.DeepEquals(
                responseData.ToJson(),
                response.ToJson()
            );
        }
    }
}