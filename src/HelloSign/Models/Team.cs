using System;
using System.Collections.Generic;

namespace HelloSign
{
    /// <summary>
    /// Representation of a HelloSign Team object.
    /// </summary>
    public class Team
    {
        public string Name { get; set; }
        public List<Account> Accounts { get; set; }
        public List<Account> InvitedAccounts { get; set; }

        public Team()
        {
            Accounts = new List<Account>();
            InvitedAccounts = new List<Account>();
        }
    }
}
