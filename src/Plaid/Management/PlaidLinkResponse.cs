using Newtonsoft.Json;

namespace Acklann.Plaid.Management
{
    public class PlaidLinkResponse
    {
        [JsonProperty("public_token")]
        public string PublicToken{ get; set; }

        [JsonProperty("link_session_id")]
        public string LinkSessionId { get; set; }

        [JsonProperty("accounts")]
        public AccountInfo[] Accounts { get; set; }

        [JsonProperty("institution")]
        public InstitutionInfo Institution { get; set; }

        public struct AccountInfo
        {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }
        }

        public struct InstitutionInfo
        {
            [JsonProperty("institution_id")]
            public string Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }
        }
    }
}