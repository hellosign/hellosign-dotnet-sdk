using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json.Linq;
using Xunit;

using HelloSign.Api;
using HelloSign.Model;

namespace HelloSign.Test.Api
{
    public class TemplateApiTests
    {
        [Fact]
        public void TemplateAddUserTest()
        {
            var templateId = "f57db65d3f933b5316d398057a36176831451a35";

            var requestData = TestHelper.SerializeFromFile<TemplateAddUserRequest>("TemplateAddUserRequest");
            var responseData = TestHelper.SerializeFromFile<TemplateGetResponse>("TemplateGetResponse");

            var api = MockRestClientHelper.CreateApi<TemplateGetResponse, TemplateApi>(responseData);

            var response = api.TemplateAddUser(templateId, requestData);

            JToken.DeepEquals(
                responseData.ToJson(),
                response.ToJson()
            );
        }

        [Fact]
        public void TemplateCreateEmbeddedDraftTest()
        {
            var requestData = TestHelper.SerializeFromFile<TemplateCreateEmbeddedDraftRequest>("TemplateCreateEmbeddedDraftRequest");
            var responseData = TestHelper.SerializeFromFile<TemplateCreateEmbeddedDraftResponse>("TemplateCreateEmbeddedDraftResponse");

            var api = MockRestClientHelper.CreateApi<TemplateCreateEmbeddedDraftResponse, TemplateApi>(responseData);

            requestData.File = new List<Stream> {
                new FileStream(
                    TestHelper.RootPath + "/pdf-sample.pdf",
                    FileMode.Open,
                    FileAccess.Read,
                    FileShare.Read
                )
            };

            var response = api.TemplateCreateEmbeddedDraft(requestData);

            JToken.DeepEquals(
                responseData.ToJson(),
                response.ToJson()
            );
        }

        [Fact(Skip="POST /template/delete/{template_id} skipped")]
        public void TemplateDeleteTest()
        {
        }

        [Fact(Skip="GET /template/files/{signature_request_id} skipped")]
        public void TemplateFilesTest()
        {
        }

        [Fact]
        public void TemplateGetTest()
        {
            var templateId = "f57db65d3f933b5316d398057a36176831451a35";

            var responseData = TestHelper.SerializeFromFile<TemplateGetResponse>("TemplateGetResponse");

            var api = MockRestClientHelper.CreateApi<TemplateGetResponse, TemplateApi>(responseData);

            var response = api.TemplateGet(templateId);

            JToken.DeepEquals(
                responseData.ToJson(),
                response.ToJson()
            );
        }

        [Fact]
        public void TemplateListTest()
        {
            var accountId = "all";

            var responseData = TestHelper.SerializeFromFile<TemplateListResponse>("TemplateListResponse");

            var api = MockRestClientHelper.CreateApi<TemplateListResponse, TemplateApi>(responseData);

            var response = api.TemplateList(accountId);

            JToken.DeepEquals(
                responseData.ToJson(),
                response.ToJson()
            );
        }

        [Fact]
        public void TemplateRemoveUserTest()
        {
            var templateId = "21f920ec2b7f4b6bb64d3ed79f26303843046536";

            var requestData = TestHelper.SerializeFromFile<TemplateRemoveUserRequest>("TemplateRemoveUserRequest");
            var responseData = TestHelper.SerializeFromFile<TemplateGetResponse>("TemplateGetResponse");

            var api = MockRestClientHelper.CreateApi<TemplateGetResponse, TemplateApi>(responseData);

            var response = api.TemplateRemoveUser(templateId, requestData);

            JToken.DeepEquals(
                responseData.ToJson(),
                response.ToJson()
            );
        }

        [Fact]
        public void TemplateUpdateFilesTest()
        {
            var templateId = "21f920ec2b7f4b6bb64d3ed79f26303843046536";

            var requestData = TestHelper.SerializeFromFile<TemplateUpdateFilesRequest>("TemplateUpdateFilesRequest");
            var responseData = TestHelper.SerializeFromFile<TemplateUpdateFilesResponse>("TemplateUpdateFilesResponse");

            var api = MockRestClientHelper.CreateApi<TemplateUpdateFilesResponse, TemplateApi>(responseData);

            requestData.File = new List<Stream> {
                new FileStream(
                    TestHelper.RootPath + "/pdf-sample.pdf",
                    FileMode.Open,
                    FileAccess.Read,
                    FileShare.Read
                )
            };

            var response = api.TemplateUpdateFiles(templateId, requestData);

            JToken.DeepEquals(
                responseData.ToJson(),
                response.ToJson()
            );
        }
    }
}