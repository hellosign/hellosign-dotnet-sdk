using System;
namespace Sample_App.model
{
    public class Email
    {
        public string toAddress { get; set; }
        public string fromAddress { get; set; }
        public string subject { get; set; }
        public string message { get; set; }
        public Email()
        {
        }

        public Email(string toAddress, string fromAddress, string subject, string message)
        {
            this.toAddress = toAddress;
            this.fromAddress = fromAddress;
            this.subject = subject;
            this.message = message;
        }
    }
}
