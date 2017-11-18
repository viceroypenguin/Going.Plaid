using Acklann.Plaid.Entity;
using Newtonsoft.Json;

namespace Acklann.Plaid.Connect
{
    public class Response : ResponseBase
    {
        [JsonProperty("accounts")]
        public Account[] Accounts { get; set; }

        [JsonProperty("transactions")]
        public Transaction[] Transactions { get; set; }
    }
}