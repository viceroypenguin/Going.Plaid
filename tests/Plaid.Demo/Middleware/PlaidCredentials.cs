using Newtonsoft.Json.Linq;
using System.IO;

namespace Acklann.Plaid.Demo.Middleware
{
    public class PlaidCredentials
    {
        public PlaidCredentials()
        {
            string secretPath = Path.Combine(System.AppContext.BaseDirectory, "secrets.json");
            var plaid = JObject.Parse(File.ReadAllText(secretPath))["plaid"];
            AccessToken = plaid?["access_token"]?.Value<string>();
            PublicKey = plaid["public_key"].Value<string>();
            ClientId = plaid["client_id"].Value<string>();
            Secret = plaid["secret"].Value<string>();
        }

        public readonly string Secret;
        public readonly string ClientId;
        public readonly string PublicKey;

        public string AccessToken;
    }
}