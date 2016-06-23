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

#if DEBUG
            _environment = Environment.Development;
            _serializerSettings = new JsonSerializerSettings()
            {
                DateFormatString = "yyyy-MM-dd",
                Formatting = Formatting.Indented
            };
#else
            _environment = environment;
            _serializerSettings = new JsonSerializerSettings() { DateFormatString = "yyyy-MM-dd" };
#endif
        }

        [JsonProperty("pin")]
        public string Pin { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("options")]
        public SubmitOptions Options { get; set; }

        public async Task<PlaidConnectResponse> AddUserAsync(PlaidConnectRequest request)
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
                        string responseBody = await response.Content.ReadAsStringAsync();
                        var result = JsonConvert.DeserializeObject<PlaidConnectResponse>(responseBody);
                        result.StatusCode = response.StatusCode;
                        return result;
                    }
                    else throw new HttpRequestException(response.ReasonPhrase);
                }
            }
        }

        public Task<PlaidConnectResponse> AddUserAsync(Credential credential, string institutionType)
        {
            var request = new PlaidConnectRequest()
            {
                Secret = base.Secret,
                Credential = credential,
                ClientId = base.ClientId,
                InstitutionType = institutionType
            };
            return AddUserAsync(request);
        }

        public Task<PlaidConnectResponse> AddUserAsync(string username, string password, string institutionType)
        {
            var request = new PlaidConnectRequest()
            {
                Secret = base.Secret,
                ClientId = base.ClientId,
                InstitutionType = institutionType,
                Credential = new Credential(username, password)
            };
            return AddUserAsync(request);
        }

        #region Private Members

        private Environment _environment;
        private JsonSerializerSettings _serializerSettings;

        #endregion Private Members
    }
}