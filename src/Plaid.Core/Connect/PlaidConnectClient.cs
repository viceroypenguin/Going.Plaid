using Gigobyte.Plaid.Contract;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Gigobyte.Plaid.Connect
{
    public class PlaidConnectClient : PlaidClientBase
    {
        public PlaidConnectClient(string clientId, string secret, Environment environment = Environment.Production) : base(clientId, secret)
        {
            _environment = environment;
        }

        public async Task<PlaidConnectResponse> AddUserAsync(PlaidConnectRequest request)
        {
            using (var http = new HttpClient())
            {
                string uri = Plaid.Endpoint.Connect(_environment).AbsoluteUri;
                string requestBody = JsonConvert.SerializeObject(request, SerializerSettings);
#if DEBUG
                System.Diagnostics.Debug.WriteLine("request");
                System.Diagnostics.Debug.WriteLine("-------");
                System.Diagnostics.Debug.WriteLine(requestBody);
#endif
                return await Deserialize<PlaidConnectResponse>(response: (await http.PostAsync(uri, new StringContent(requestBody, Encoding.UTF8, ContentType))));
            }
        }

        /* /connect */

        public Task<PlaidConnectResponse> AddUserAsync(Credential credential, string institutionType, string pin = null)
        {
            return AddUserAsync(new PlaidConnectRequest()
            {
                Pin = pin,
                Secret = base.Secret,
                Credential = credential,
                ClientId = base.ClientId,
                InstitutionType = institutionType,
                Options = new ConnectOptions() { LoginOnly = true }
            });
        }

        public Task<PlaidConnectResponse> AddUserAsync(string username, string password, string institutionType, string pin = null)
        {
            return AddUserAsync(new PlaidConnectRequest()
            {
                Pin = pin,
                Secret = base.Secret,
                ClientId = base.ClientId,
                InstitutionType = institutionType,
                Credential = new Credential(username, password),
                Options = new ConnectOptions() { LoginOnly = true }
            });
        }

        public Task<PlaidConnectResponse> AddUserAsync(Credential credential, string institutionType, ConnectOptions options, string pin = null)
        {
            return AddUserAsync(new PlaidConnectRequest()
            {
                Pin = pin,
                Options = options,
                Secret = base.Secret,
                Credential = credential,
                ClientId = base.ClientId,
                InstitutionType = institutionType
            });
        }

        public Task<PlaidConnectResponse> AddUserAsync(string username, string password, string institutionType, ConnectOptions options, string pin = null)
        {
            return AddUserAsync(new PlaidConnectRequest()
            {
                Pin = pin,
                Options = options,
                Secret = base.Secret,
                ClientId = base.ClientId,
                InstitutionType = institutionType,
                Credential = new Credential(username, password)
            });
        }

        /* /connect/step */

        public async Task<PlaidConnectResponse> AuthenticateUserAsync(PlaidConnectRequest request)
        {
            using (var http = new HttpClient())
            {
                string url = Plaid.Endpoint.ConnectStep(_environment).AbsoluteUri;
                string requestBody = JsonConvert.SerializeObject(request, SerializerSettings);
#if DEBUG
                System.Diagnostics.Debug.WriteLine("request");
                System.Diagnostics.Debug.WriteLine("----------");
                System.Diagnostics.Debug.WriteLine(requestBody);
#endif
                return await Deserialize<PlaidConnectResponse>(response: (await http.PostAsync(url, new StringContent(requestBody, Encoding.UTF8, ContentType))));
            }
        }

        public Task<PlaidConnectResponse> AuthenticateUserAsync(Credential credential, string accessToken, string mfa, string pin = null)
        {
            return AuthenticateUserAsync(new PlaidConnectRequest()
            {
                Pin = pin,
                Mfa = mfa,
                Secret = base.Secret,
                Credential = credential,
                ClientId = base.ClientId,
                AccessToken = accessToken
            });
        }

        public Task<PlaidConnectResponse> AuthenticateUserAsync(string username, string password, string accessToken, string mfa, string pin = null)
        {
            return AuthenticateUserAsync(new PlaidConnectRequest()
            {
                Pin = pin,
                Mfa = mfa,
                Secret = base.Secret,
                ClientId = base.ClientId,
                AccessToken = accessToken,
                Credential = new Credential(username, password)
            });
        }

        public Task<PlaidConnectResponse> AuthenticateUserAsync(Credential credential, string accessToken, AuthenticationOption method, string mfa, string pin = null)
        {
            return AuthenticateUserAsync(new PlaidConnectRequest()
            {
                Pin = pin,
                Mfa = mfa,
                Secret = base.Secret,
                Credential = credential,
                ClientId = base.ClientId,
                AccessToken = accessToken,
                AuthenticationMethod = method
            });
        }

        public Task<PlaidConnectResponse> AuthenticateUserAsync(string username, string password, string accessToken, AuthenticationOption method, string mfa, string pin = null)
        {
            return AuthenticateUserAsync(new PlaidConnectRequest()
            {
                Pin = pin,
                Mfa = mfa,
                Secret = base.Secret,
                ClientId = base.ClientId,
                AccessToken = accessToken,
                AuthenticationMethod = method,
                Credential = new Credential(username, password)
            });
        }

        /* /connect/get */

        public async Task<PlaidConnectResponse> RetrieveTransactionsAsync(PlaidConnectRequest request)
        {
            using (var http = new HttpClient())
            {
                string uri = Plaid.Endpoint.ConnectGet(_environment).AbsoluteUri;
                string requestBody = JsonConvert.SerializeObject(request, SerializerSettings);
#if DEBUG
                System.Diagnostics.Debug.WriteLine("request");
                System.Diagnostics.Debug.WriteLine("-------");
                System.Diagnostics.Debug.WriteLine(requestBody);
#endif
                return await Deserialize<PlaidConnectResponse>(response: (await http.PostAsync(uri, new StringContent(requestBody, Encoding.UTF8, ContentType))));
            }
        }

        public Task<PlaidConnectResponse> RetrieveTransactionsAsync(string accessToken)
        {
            return RetrieveTransactionsAsync(new PlaidConnectRequest()
            {
                Secret = base.Secret,
                ClientId = base.ClientId,
                AccessToken = accessToken
            });
        }

        public Task<PlaidConnectResponse> RetrieveTransactionsAsync(string accessToken, ConnectOptions options)
        {
            return RetrieveTransactionsAsync(new PlaidConnectRequest()
            {
                Options = options,
                Secret = base.Secret,
                ClientId = base.ClientId,
                AccessToken = accessToken
            });
        }

        /* /connect (PATCH) */

        public Task<PlaidConnectResponse> UpdateUserAsync(PlaidConnectRequest request)
        {
            throw new System.NotImplementedException();
        }

        #region Private Members

        private readonly Environment _environment;

        #endregion Private Members
    }
}