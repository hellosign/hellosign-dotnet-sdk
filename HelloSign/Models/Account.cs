using System;
using System.Collections.Generic;

namespace HelloSign
{
    /// <summary>
    /// Representation of a HelloSign Account object.
    /// </summary>
    public class Account
    {
        public enum Role
        {
            ADMIN = 'A',
            MEMBER = 'M',
        }

        public string AccountId { get; set; }
        public string EmailAddress { get; set; }
        public bool? IsPaidHs { get; set; }
        public bool? IsPaidHf { get; set; }
        public string CallbackUrl { get; set; }
        public Dictionary<string, int?> Quotas { get; set; }
        public string RoleCode { get; set; }
    }
}
