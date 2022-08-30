using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Xunit;
using HelloSign.Model;

namespace HelloSign.Test
{
    public class EventCallbackHelperTests
    {
        private const string ApiKey = "324e3b0840f065eb51f3fd63231d0d33daa35d4ed10d27718839e81737065782";

        [Fact]
        public void IsValidTest()
        {
            using (var r = TestHelper.ReadFileFromResource("EventCallbackHelper"))
            {
                var payload = JsonConvert.DeserializeObject<Dictionary<string, EventCallbackApiAppRequestPayload>>(r.ReadToEnd());
                Assert.NotNull(payload);

                foreach(var item in payload.Values)
                {
                    Assert.True(EventCallbackHelper.IsValid(ApiKey, item.Event));
                    Assert.False(EventCallbackHelper.IsValid(Reverse(ApiKey), item.Event));
                }
            }
        }

        private string Reverse(string text)
        {
            var arr = text.ToCharArray();
            Array.Reverse(arr);
            return new String(arr);
        }
    }
}
