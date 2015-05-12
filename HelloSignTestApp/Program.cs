using System;

namespace HelloSignTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Client setup
            //var client = new HelloSign.Client();
            var client = new HelloSign.Client();
            client.SetEnvironment(HelloSign.Client.Environment.Staging);
            
            // Call API
            var account = client.GetAccount();
            //var account = client.CreateAccount("stephen+csharp@hellosign.com");
            //var account = client.UpdateAccount(new Uri("http://example.com"));
            Console.WriteLine(account.CallbackUrl);

            Console.WriteLine("Press ENTER to exit.");
            Console.Read(); // Keeps the output window open
        }
    }
}
