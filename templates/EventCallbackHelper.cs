using System;
using System.Security.Cryptography;
using System.Text;
using HelloSign.Client;
using HelloSign.Model;

namespace HelloSign
{
    public class EventCallbackHelper
    {
        public const string EVENT_TYPE_ACCOUNT_CALLBACK = "account_callback";

        public const string EVENT_TYPE_APP_CALLBACK = "app_callback";

        private EventCallbackHelper() {}

        /// <summary>
        /// Verify that a callback came from HelloSign.com
        /// </summary>
        public static bool IsValid(string apiKey, EventCallbackRequest eventCallback)
        {
            var eventType = ClientUtils.GetEnumMemberAttrValue(eventCallback.Event.EventType);
            var message = eventCallback.Event.EventTime + eventType;

            return GetHash(message, apiKey) == eventCallback.Event.EventHash;
        }

        /// <summary>
        /// Identifies the callback type, one of "account_callback" or "app_callback".
        /// "app_callback" will always include a value for "reported_for_app_id"
        /// </summary>
        /// <param name="eventCallback"></param>
        /// <returns></returns>
        public static string GetCallbackType(EventCallbackRequest eventCallback)
        {
            var metaData = eventCallback.Event.EventMetadata;

            if (String.IsNullOrEmpty(metaData.ReportedForAppId))
            {
                return EVENT_TYPE_ACCOUNT_CALLBACK;
            }

            return EVENT_TYPE_APP_CALLBACK;
        }

        private static string GetHash(string text, string key)
        {
            var encoding = new UTF8Encoding();

            var textBytes = encoding.GetBytes(text);
            var keyBytes = encoding.GetBytes(key);

            var hash = new HMACSHA256(keyBytes);
            var hashBytes = hash.ComputeHash(textBytes);

            return BitConverter.ToString(hashBytes)
                .Replace("-", "")
                .ToLower();
        }
    }
}
