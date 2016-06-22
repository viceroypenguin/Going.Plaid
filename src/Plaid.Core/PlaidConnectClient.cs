using Gigobyte.Plaid.Contract;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Gigobyte.Plaid
{
    [JsonObject]
    public class PlaidConnectClient : PlaidClientBase
    {
        public PlaidConnectClient(string clientId, string secret, Environment environment = Environment.Production) : base(clientId, secret)
        {
            _environment = environment;

            _serializerSettings = new JsonSerializerSettings()
            {
                DateFormatString = "yyyy-MM-dd",
#if DEBUG
                Formatting = Formatting.Indented
#endif
            };
        }

        [JsonProperty("pin")]
        public string Pin { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("options")]
        public SubmitOptions Options { get; set; }

        public Task<bool> AddUserAsync(Credential credential, string institutionType)
        {
            var request = new PlaidConnectRequest()
            {
                Secret = base.Secret,
                Credential = credential,
                ClientId = base.ClientId,
                InstitutionType = institutionType
            };
            return AddUser(request);
        }

        public async Task<bool> AddUser(PlaidConnectRequest request)
        {
            request.Options.LoginOnly = true;

            using (var client = new HttpClient())
            {
                string url = GetEndpoint(_environment, "connect").AbsoluteUri;
                string requestBody = JsonConvert.SerializeObject(request, _serializerSettings);

                using (var response = await client.PostAsync(url, new StringContent(requestBody, Encoding.UTF8, ContentType)))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        System.Diagnostics.Debug.WriteLine(json);
                        //var plaidReply = (PlaidConnectResponse)JsonConvert.DeserializeObject(json, typeof(PlaidConnectResponse));


                    }
                    else throw new HttpRequestException(response.ReasonPhrase);
                }
            }

            return true;
        }
        
        #region Private Members

        private Environment _environment;

        private JsonSerializerSettings _serializerSettings;

        #endregion Private Members
    }
}