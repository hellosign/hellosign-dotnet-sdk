using System;
using Org.HelloSign.Client;

namespace Sample_App.common
{
    public class ConfigurationFactory
    {
        private ConfigurationFactory()
        {
        }

        public static Configuration GetConfiguration(string domain, string apikey)
        {
            var config = new Configuration();
            config.BasePath = String.Format("https://{0}/v3", domain);
            config.Username = apikey;
            return config;
        }
    }
}
