using System.Collections.Generic;

namespace HelloSign
{
    /// <summary>
    /// Information about a recipient (a signer) of a Signature Request.
    /// </summary>
    public class Signer : SignerRole
    {
        public string EmailAddress { get; set; }
        public string Pin { get; set; }
        public string Role { get; set; }
        public string SmsPhoneNumber { get; set; }

        /// <summary>
        /// Create a new Signer object quickly.
        /// </summary>
        /// <param name="EmailAddress"></param>
        /// <param name="Name"></param>
        /// <param name="Order">Optional order of signing, starting from 1. If any Signer has Order set, then all must.</param>
        /// <param name="Pin">Optional 4- to 12-digit passphrase the signer must use to access the document.</param>
        /// <param name="SmsPhoneNumber">Optional Phone number for SMS verification</param>
        /// <param name="role">Optional Role name (if this is for a Template)</param>
        public Signer(string emailAddress, string name, int? order = null, string pin = null, string smsPhoneNumber = null, string role = null)
        {
            EmailAddress = emailAddress;
            Name = name;
            Order = order;
            Pin = pin;
            Role = role;
            SmsPhoneNumber = smsPhoneNumber;
        }
    }
}
