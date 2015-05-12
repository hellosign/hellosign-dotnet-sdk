using System;
using System.Collections.Generic;
using System.Net;
using RestSharp;

namespace HelloSign
{
    public class Client
    {
        /// <summary>
        /// Specifies different HelloSign environments that can be reached.
        /// </summary>
        public enum Environment {
            Prod,
            Staging,
        }

        private RestClient client;

        /// <summary>
        /// Default constructor with no authentication.
        /// Limited to unauthenticated calls only.
        /// </summary>
        public Client()
        {
            client = new RestClient();
            SetEnvironment(Environment.Prod);
        }

        /// <summary>
        /// Constructor initialized with API key authentication.
        /// </summary>
        /// <param name="apiKey">Your HelloSign account API key.</param>
        public Client(string apiKey) : this()
        {
            client.Authenticator = new HttpBasicAuthenticator(apiKey, "");
        }

        /// <summary>
        /// Constructor initialized with username/password authentication.
        /// Not preferred; Please use API key authentication instead.
        /// </summary>
        /// <param name="username">Your HelloSign account email address.</param>
        /// <param name="password">Your HelloSign account password.</param>
        public Client(string username, string password) : this()
        {
            client.Authenticator = new HttpBasicAuthenticator(username, password);
        }

        /// <summary>
        /// Execute an API call using RestSharp and deserialize the response
        /// into a native object of class T.
        /// </summary>
        /// <typeparam name="T">The class to deserialize the response into.</typeparam>
        /// <param name="request">The RestRequest object to execute.</param>
        /// <returns></returns>
        private T Execute<T>(RestRequest request) where T : new()
        {
            var response = client.Execute<T>(request);
            
            // Handle errors
            if (response.ErrorException != null)
            {
                const string message = "Error retrieving response.  Check inner details for more info.";
                throw new ApplicationException(message, response.ErrorException);
            }
            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new ApplicationException("Received status " + response.StatusCode.GetHashCode() + " from server. Full response:\n" + response.Content);
            }

            return response.Data;
        }

        /// <summary>
        /// Set the client to point to a different environment.
        /// Not useful to the general public.
        /// </summary>
        /// <param name="env"></param>
        public void SetEnvironment(Environment env)
        {
            string baseUrl;
            switch (env)
            {
                case Environment.Prod:
                    baseUrl = "https://api.hellosign.com/v3";
                    break;
                case Environment.Staging:
                    baseUrl = "https://api-staging.hellosign.com/v3";
                    break;
                default:
                    throw new ArgumentException("Unsupported environment given");
            }
            client.BaseUrl = new Uri(baseUrl);
        }

        #region Account Methods

        /// <summary>
        /// Create a new HelloSign account.
        /// The account must not already exist, and the user must confirm their
        /// email address before actions can be performed on this user's
        /// behalf.
        /// </summary>
        /// <param name="email_address"></param>
        /// <returns>The new Account</returns>
        public Account CreateAccount(string email_address)
        {
            if (String.IsNullOrWhiteSpace(email_address))
            {
                throw new ArgumentException("email_address is required");
            }

            var request = new RestRequest("account/create", Method.POST);
            request.AddParameter("email_address", email_address); 
            request.RootElement = "account";
            return Execute<Account>(request);
        }

        /// <summary>
        /// Get information about the currently authenticated account.
        /// </summary>
        /// <returns>Your Account</returns>
        public Account GetAccount()
        {
            if (client.Authenticator == null)
            {
                throw new UnauthorizedAccessException("This method requires authentication");
            }

            var request = new RestRequest("account");
            request.RootElement = "account";
            return Execute<Account>(request);
        }

        /// <summary>
        /// Update your account settings (callback URL).
        /// </summary>
        /// <param name="callback_url">Your new account callback URL.</param>
        /// <returns>Your Account</returns>
        public Account UpdateAccount(Uri callback_url)
        {
            if (client.Authenticator == null)
            {
                throw new UnauthorizedAccessException("This method requires authentication");
            }

            var request = new RestRequest("account", Method.POST);
            request.AddParameter("callback_url", callback_url);
            request.RootElement = "account";
            return Execute<Account>(request);
        }

        #endregion
    }
}
