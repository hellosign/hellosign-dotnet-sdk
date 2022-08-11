using System;
namespace Sample_App.model
{
    public class User
    {
        public string name { get;}
        public string emailAddress { get; }
        public string role { get; set; }
        public User(string name, string emailAddress)
        {
            this.name = name;
            this.emailAddress = emailAddress;
        }

        public User(string name, string emailAddress, string role): this(name, emailAddress)
        {
            this.role = role;
        }
    }
}
