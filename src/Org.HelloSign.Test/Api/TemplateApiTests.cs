using System.Net;
using Newtonsoft.Json.Linq;
using Xunit;

using Org.HelloSign.Client;
using Org.HelloSign.Api;
using Org.HelloSign.Model;

namespace Org.HelloSign.Test.Api
{
    public class TemplateApiTests
    {
        private readonly MockRestClient _mock;
        private readonly TemplateApi _api;

        public TemplateApiTests()
        {
            _mock = new MockRestClient();

            Configuration config = new Configuration();
            config.Username = "YOUR_API_KEY";

            var client = new ApiClient(config.BasePath, _mock);
            _api = new TemplateApi(client, client, config);
        }

        [Fact]
        public void TemplateAddUserTest()
        {
            var templateId = "f57db65d3f933b5316d398057a36176831451a35";

            var requestData = TestHelper.SerializeFromFile<TemplateAddUserRequest>("TemplateAddUserRequest");
            var responseData = TestHelper.SerializeFromFile<TemplateGetResponse>("TemplateGetResponse");

            _mock.SetExpectedResponse(responseData, HttpStatusCode.Accepted);

            var response = _api.TemplateAddUser(templateId, requestData);

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

            _mock.SetExpectedResponse(responseData, HttpStatusCode.Accepted);

            var response = _api.TemplateCreateEmbeddedDraft(requestData);

            JToken.DeepEquals(
                responseData.ToJson(),
                response.ToJson()
            );
        }

        [Fact(Skip="POST /template/delete/{template_id} skipped")]
        public void TemplateDeleteTest()
        {
        }

        [Fact]
        public void TemplateFilesTest()
        {
            var templateId = "f57db65d3f933b5316d398057a36176831451a35";
            var fileType = "pdf";
            var getUrl = false;
            var getDataUri = false;

            var responseData = TestHelper.SerializeFromFile<FileResponse>("FileResponse");

            _mock.SetExpectedResponse(responseData, HttpStatusCode.Accepted);

            var response = _api.TemplateFiles(
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
        public void TemplateGetTest()
        {
            var templateId = "f57db65d3f933b5316d398057a36176831451a35";

            var responseData = TestHelper.SerializeFromFile<TemplateGetResponse>("TemplateGetResponse");

            _mock.SetExpectedResponse(responseData, HttpStatusCode.Accepted);

            var response = _api.TemplateGet(templateId);

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

            _mock.SetExpectedResponse(responseData, HttpStatusCode.Accepted);

            var response = _api.TemplateList(accountId);

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

            _mock.SetExpectedResponse(responseData, HttpStatusCode.Accepted);

            var response = _api.TemplateRemoveUser(templateId, requestData);

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

            _mock.SetExpectedResponse(responseData, HttpStatusCode.Accepted);

            var response = _api.TemplateUpdateFiles(templateId, requestData);

            JToken.DeepEquals(
                responseData.ToJson(),
                response.ToJson()
            );
        }
    }
}
