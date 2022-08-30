using System;
using System.Security.Cryptography;
using System.Text;
using HelloSign.Client;
using HelloSign.Model;

namespace HelloSign
{
    public class EventCallbackHelper
    {
        private EventCallbackHelper() {}

        /// <summary>
        /// Verify that a callback came from HelloSign.com
        /// </summary>
        public static bool IsValid(string apiKey, EventCallbackRequestEvent eventCallback)
        {
            var eventType = ClientUtils.GetEnumMemberAttrValue(eventCallback.EventType);
            var message = eventCallback.EventTime + eventType;

            return GetHash(message, apiKey) == eventCallback.EventHash;
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
