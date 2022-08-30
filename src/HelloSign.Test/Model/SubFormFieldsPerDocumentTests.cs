using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Xunit;
using HelloSign.Model;

namespace HelloSign.Test.Model
{
    public class SubFormFieldsPerDocumentTests
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void SubFormFieldsPerDocumentBaseTest(Dictionary<string, object> items)
        {
            var signer1 = new JObject(
                new JProperty("name", "Signer 1"),
                new JProperty("email_address", "s1@example.com")
            );

            foreach (var item in items)
            {
                var data = new JObject(
                    new JProperty("signers", new JArray(signer1)),
                    new JProperty("form_fields_per_document", new JArray(item.Value))
                );

                var obj = JsonConvert.DeserializeObject<SignatureRequestSendRequest>(data.ToString());

                Assert.NotNull(obj);

                var field = obj.FormFieldsPerDocument[0];

                Assert.Equal(item.Key, field.GetType().Name);
            }
        }

        public static IEnumerable<object[]> Data()
        {
            using (var r = TestHelper.ReadFileFromResource("SubFormFieldsPerDocument"))
            {
                var payload = JsonConvert.DeserializeObject<Dictionary<string, object>>(r.ReadToEnd());
                Assert.NotNull(payload);

                return new List<object[]> {new object[] {payload}};
            }
        }
    }
}
