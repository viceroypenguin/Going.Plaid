using Newtonsoft.Json;
using System;

namespace Gigobyte.Plaid
{
    public abstract class PlaidClientBase
    {
        public PlaidClientBase(string clientId, string secret)
        {
            Secret = secret;
            ClientId = clientId;
        }

        protected const string ContentType = "application/json";

        [JsonProperty("secret")]
        protected string Secret { get; set; }

        [JsonProperty("client_id")]
        protected string ClientId { get; set; }

        [JsonProperty("access_token")]
        protected string AccessToken { get; set; }

        public static Uri GetEndpoint(Environment environment, string path)
        {
            switch (environment)
            {
                case Environment.Development:
                    return new UriBuilder()
                    {
                        Scheme = "https",
                        Host = "tartan.plaid.com",
                        Path = path
                    }.Uri;

                default:
                case Environment.Production:
                    return new UriBuilder()
                    {
                        Scheme = "https",
                        Host = "api.plaid.com",
                        Path = path
                    }.Uri;
            }
        }
    }
}