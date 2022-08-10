using System;
namespace Sample_App.model
{
    public class User
    {
        public string name { get;}
        public string emailAddress { get; }
        public User(string name, string emailAddress)
        {
            this.name = name;
            this.emailAddress = emailAddress;
        }
    }
}
