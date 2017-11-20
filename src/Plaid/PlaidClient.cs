using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Acklann.Plaid
{
    public class PlaidClient
    {
        public PlaidClient() : this(null, null, null, Plaid.Environment.Production)
        {
        }

        public PlaidClient(Plaid.Environment environment) : this(null, null, null, environment)
        {
        }

        public PlaidClient(string clientId, string secret, string accessToken, Plaid.Environment environment = Plaid.Environment.Production)
        {
            _secret = secret;
            _clientId = clientId;
            _accessToken = accessToken;
            _environment = environment;
        }

        /* Item Management */

        public Task<Management.GetItemResponse> FetchItemAsync(Management.GetItemRequest request)
        {
            return PostAsync<Management.GetItemResponse>("item/get", request);
        }

        public Task<Management.DeleteItemResponse> DeleteItemAsync(Management.DeleteItemRequest request)
        {
            return PostAsync<Management.DeleteItemResponse>("item/delete", request);
        }

        public Task<Management.UpdateWebhookResponse> UpdateWebhookAsync(Management.UpdateWebhookRequest request)
        {
            return PostAsync<Management.UpdateWebhookResponse>("item/webhook/update", request);
        }

        public Task<Management.ExchangeTokenResponse> ExchangeTokenAsync(Management.ExchangeTokenRequest request)
        {
            return PostAsync<Management.ExchangeTokenResponse>("item/public_token/exchange", request);
        }

        public Task<Management.RotateAccessTokenResponse> RotateAccessTokenAsync(Management.RotateAccessTokenRequest request)
        {
            return PostAsync<Management.RotateAccessTokenResponse>("item/access_token/invalidate", request);
        }

        public Task<Management.UpdateAccessTokenVersionResponse> UpdateAccessTokenVersion(Management.UpdateAccessTokenVersionRequest request)
        {
            return PostAsync<Management.UpdateAccessTokenVersionResponse>("item/access_token/update_version", request);
        }

        /* Institutions */

        public Task<Institution.SearchResponse> FetchInstitutionsAsync(Institution.SearchRequest request)
        {
            return PostAsync<Institution.SearchResponse>("institutions/search", request);
        }

        public Task<Institution.SearchByIdResponse> FetchInstitutionByIdAsync(Institution.SearchByIdRequest request)
        {
            return PostAsync<Institution.SearchByIdResponse>("institutions/get_by_id", request);
        }

        /* Income */

        public Task<Income.GetIncomeResponse> FetchUserIncomeAsync(Income.GetIncomeRequest request)
        {
            return PostAsync<Income.GetIncomeResponse>("income/get", request);
        }

        /* Auth */

        public Task<Auth.GetAccountInfoResponse> FetchAccountInfoAsync(Auth.GetAccountInfoRequest request)
        {
            return PostAsync<Auth.GetAccountInfoResponse>("auth/get", request);
        }

        /* Balance */

        public Task<Balance.GetBalanceResponse> FetchAccountBalanceAsync(Balance.GetBalanceRequest request)
        {
            return PostAsync<Balance.GetBalanceResponse>("accounts/balance/get", request);
        }

        /* Categories */

        public Task<Category.GetCategoriesResponse> FetchCategoriesAsync(Category.GetCategoriesRequest request)
        {
            return PostAsync<Category.GetCategoriesResponse>("categories/get", request);
        }

        /* Identity */

        public Task<Identity.GetUserIdentityResponse> FetchUserIdentityAsync(Identity.GetUserIdentityRequest request)
        {
            return PostAsync<Identity.GetUserIdentityResponse>("identity/get", request);
        }

        /* Transactions */

        public Task<Transactions.GetTransactionsResponse> FetchTransactionsAsync(Transactions.GetTransactionsRequest request)
        {
            return PostAsync<Transactions.GetTransactionsResponse>("transactions/get", request);
        }

        /* ***** */

        public string GetEndpoint(string path)
        {
            string subDomain = "";
            switch (_environment)
            {
                default:
                case Environment.Production:
                    subDomain = "production.";
                    break;

                case Environment.Development:
                    subDomain = "development.";
                    break;

                case Environment.Sandbox:
                    subDomain = "sandbox.";
                    break;

                case Environment.Tartan:
                    subDomain = "tartan.";
                    break;

                case Environment.Lagacy:
#if DEBUG
                    subDomain = "tartan.";
#else
                    subDomain = "api.";
#endif
                    break;
            }

            return new UriBuilder()
            {
                Scheme = Uri.UriSchemeHttps,
                Host = $"{subDomain}plaid.com",
                Path = path.Trim(' ', '/', '\\')
            }.Uri.AbsoluteUri;
        }

        public async Task<TResponse> PostAsync<TResponse>(string path, SerializableContent request) where TResponse : ResponseBase
        {
            EnsureCredentials(request);

            using (var http = new HttpClient())
            {
                string url = GetEndpoint(path);
                string json = request.ToJson();
                Log(json, $"POST: '{url}'");

                using (HttpResponseMessage response = await http.PostAsync(url, Body(json)))
                {
                    json = await response.Content.ReadAsStringAsync();
                    Log(json, $"RESPONSE ({response.StatusCode})");
                    TResponse result = JsonConvert.DeserializeObject<TResponse>(json);
                    result.StatusCode = response.StatusCode;

                    if (response.IsSuccessStatusCode == false)
                    {
                        var error = JObject.Parse(json);
                        result.Exception = new Exceptions.PlaidException(error["error_message"].Value<string>())
                        {
                            HelpLink = "https://plaid.com/docs/api/#errors-overview",
                            DisplayMessage = error["display_message"].Value<string>(),
                            ErrorType = error["error_type"].Value<string>(),
                            ErrorCode = error["error_code"].Value<string>(),
                            Source = url,
                        };
                    }
#if DEBUG
                    result.RawJsonForDebugging = json;
#endif
                    return result;
                }
            }
        }

        #region Private Members

        private readonly Plaid.Environment _environment;

        private readonly string _clientId, _secret, _accessToken;

        private static HttpContent Body(string json)
        {
            return new StringContent(json, Encoding.UTF8, "application/json");
        }

        private static void Log(string message, string title = "RESPONSE")
        {
#if DEBUG
            var line = string.Concat(Enumerable.Repeat('-', 100));
            int n = (title.Length > line.Length) ? line.Length : (line.Length - title.Length + 2);

            System.Diagnostics.Debug.WriteLine(line.Substring(0, n).Insert(5, $" {title} "));
            System.Diagnostics.Debug.WriteLine(message);
#endif
        }

        private void EnsureCredentials(object request)
        {
            if (request is RequestBase req)
            {
                if (string.IsNullOrEmpty(req.Secret)) req.Secret = _secret;
                if (string.IsNullOrEmpty(req.ClientId)) req.ClientId = _clientId;
                if (string.IsNullOrEmpty(req.AccessToken)) req.AccessToken = _accessToken;
            }
        }

        #endregion Private Members
    }
}