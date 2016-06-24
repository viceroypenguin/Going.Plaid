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
#if DEBUG
            _serializerSettings = new JsonSerializerSettings() { Formatting = Formatting.Indented };
#else
            _serializerSettings = new JsonSerializerSettings();
#endif
            _environment = environment;
            _serializerSettings.DateFormatString = "yyyy-MM-dd";
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

            using (var http = new HttpClient())
            {
                string url = Plaid.Endpoint.Connect(_environment);
                string requestBody = JsonConvert.SerializeObject(request, _serializerSettings);
                return await Deserialize<PlaidConnectResponse>(response: (await http.PostAsync(url, new StringContent(requestBody, Encoding.UTF8, ContentType))));
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

        private readonly JsonSerializerSettings _serializerSettings;
        private Environment _environment;

        #endregion Private Members
    }
}