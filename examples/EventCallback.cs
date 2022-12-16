using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using HelloSign.Model;
using HelloSign;

public class Example
{
    public static void Main()
    {
        // use your API key
        var apiKey = "324e3b0840f065eb51f3fd63231d0d33daa35d4ed10d27718839e81737065782";

        // callbackData represents data we send to you
        var callbackData = new Dictionary<string, object>()
        {
            ["event"] = new Dictionary<string, object>()
            {
                ["event_type"]     = "account_confirmed",
                ["event_time"]     = "1669926463",
                ["event_hash"]     = "ff8b03439122f9160500c3fb855bdee5a9ccba5fff27d3b258745d8f3074832f",
                ["event_metadata"] = new Dictionary<string, object>()
                {
                    ["related_signature_id"]    = null,
                    ["reported_for_account_id"] = "6421d70b9bd45059fa207d03ab8d1b96515b472c",
                    ["reported_for_app_id"]     = null,
                    ["event_message"]           = null,
                }
            }
        };

        var json = JsonConvert.SerializeObject(callbackData);

        var callbackEvent = JsonConvert.DeserializeObject<EventCallbackRequest>(json);
        if (callbackEvent == null)
        {
            throw new Exception("Invalid data provided");
        }

        // verify that a callback came from HelloSign.com
        var isValid = EventCallbackHelper.IsValid(apiKey, callbackEvent);
        if (EventCallbackHelper.IsValid(apiKey, callbackEvent))
        {
            // one of "account_callback" or "api_app_callback"
            var callbackType = EventCallbackHelper.GetCallbackType(callbackEvent);

            // do your magic below!
        }
    }
}
