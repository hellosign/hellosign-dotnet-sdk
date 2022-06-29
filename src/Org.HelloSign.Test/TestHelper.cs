using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Org.HelloSign.Model;
using Xunit;

namespace Org.HelloSign.Test
{
    public class TestHelper
    {
        private const string RootPath = "../../../../../oas/test_fixtures";

        public static StreamReader ReadFileFromResource(string fileName)
        {
            return new StreamReader(
                RootPath + $"/{fileName}.json"
            );
        }

        public static FileStream GetFile(string fileName)
        {
            return new FileStream(
                RootPath + $"/{fileName}",
                FileMode.Open,
                FileAccess.Read,
                FileShare.Read
            );
        }

        public static T SerializeFromFile<T>(
            string fileName,
            string key = "default"
        ) where T : IOpenApiTyped
        {
            T instance = (T)Activator.CreateInstance(typeof(T), true);

            using (var r = TestHelper.ReadFileFromResource(fileName))
            {
                dynamic json = JsonConvert.DeserializeObject<object>(r.ReadToEnd());
                Assert.NotNull(json);

                var rawData = json[key];
                var files = ExtractFileStreams(rawData, instance.GetOpenApiTypes());

                var requestData = JsonConvert.DeserializeObject<T>(rawData.ToString());
                Assert.NotNull(requestData);

                Type type = requestData.GetType();
                Assert.NotNull(type);

                foreach (var file in files)
                {
                    type.GetProperty(file.Key)?.SetValue(requestData, file.Value);
                }

                return requestData;
            }
        }

        /**
         * For data fixtures with file parameters, remove the values from original
         * JSON object and instantiate them as their correct Stream type so we
         * can inject into the instantiated Model object afterward.
         */
        private static Dictionary<string, dynamic> ExtractFileStreams(
            JObject json,
            List<OpenApiType> items
        )
        {
            var files = new Dictionary<string, dynamic>();

            foreach (var item in items)
            {
                var name = item.Name;
                var property = item.Property;
                var value = json.GetValue(name);
                var type = item.Type;

                if (
                    value == null ||
                    (type != "System.IO.Stream" &&
                     type != "List<System.IO.Stream>")
                )
                {
                    continue;
                }

                if (type == "System.IO.Stream")
                {
                    files.Add(property, GetFile(value.ToString()));
                    json.Remove(name);

                    continue;
                }

                if (type == "List<System.IO.Stream>")
                {
                    var iFiles = new List<Stream>();

                    foreach (var iValue in value)
                    {
                        iFiles.Add(GetFile(iValue.ToString()));
                    }

                    files.Add(property, iFiles);
                    json.Remove(name);

                    continue;
                }
            }

            return files;
        }
    }
}
