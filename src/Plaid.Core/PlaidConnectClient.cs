using Gigobyte.Plaid.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Gigobyte.Plaid
{
    [JsonObject]
    public class PlaidConnectClient : PlaidClientBase
    {
        public PlaidConnectClient(string clientId, string secret, Environment environment = Environment.Production) : base(clientId, secret)
        {

        }



        [JsonProperty("pin")]
        public string Pin { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("credentials")]
        public Credential Credential { get; set; }

        [JsonProperty("options")]
        public SubmitOptions Options { get; set; }

    }
}
