using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Acklann.Plaid
{
    /// <summary>
    /// Provides methods for sending request to and receiving data from Plaid banking API.
    /// </summary>
    public class PlaidClient
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlaidClient"/> class.
        /// </summary>
        public PlaidClient() : this(null, null, null, Plaid.Environment.Production)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaidClient"/> class.
        /// </summary>
        /// <param name="environment">The environment.</param>
        public PlaidClient(Plaid.Environment environment) : this(null, null, null, environment)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaidClient"/> class.
        /// </summary>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="secret">The secret.</param>
        /// <param name="accessToken">The access token.</param>
        /// <param name="environment">The environment.</param>
        public PlaidClient(string clientId, string secret, string accessToken, Plaid.Environment environment = Plaid.Environment.Production)
        {
            _secret = secret;
            _clientId = clientId;
            _accessToken = accessToken;
            _environment = environment;
        }

        /* Item Management */

        /// <summary>
        /// Retrieves information about the status of an <see cref="Entity.Item"/>. Endpoint '/item/get'.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>Task&lt;Management.GetItemResponse&gt;.</returns>
        public Task<Management.GetItemResponse> FetchItemAsync(Management.GetItemRequest request)
        {
            return PostAsync<Management.GetItemResponse>("item/get", request);
        }

        /// <summary>
        /// Delete an <see cref="Entity.Item"/>. Once deleted, the access_token associated with the <see cref="Entity.Item"/> is no longer valid and cannot be used to access any data that was associated with the <see cref="Entity.Item"/>.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>Task&lt;Management.DeleteItemResponse&gt;.</returns>
        public Task<Management.DeleteItemResponse> DeleteItemAsync(Management.DeleteItemRequest request)
        {
            return PostAsync<Management.DeleteItemResponse>("item/delete", request);
        }

        /// <summary>
        /// Updates the webhook associated with an <see cref="Entity.Item"/>. This request triggers a WEBHOOK_UPDATE_ACKNOWLEDGED webhook.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>Task&lt;Management.UpdateWebhookResponse&gt;.</returns>
        public Task<Management.UpdateWebhookResponse> UpdateWebhookAsync(Management.UpdateWebhookRequest request)
        {
            return PostAsync<Management.UpdateWebhookResponse>("item/webhook/update", request);
        }

        /// <summary>
        /// Exchanges a Link public_token for an API access_token.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>Task&lt;Management.ExchangeTokenResponse&gt;.</returns>
        public Task<Management.ExchangeTokenResponse> ExchangeTokenAsync(Management.ExchangeTokenRequest request)
        {
            return PostAsync<Management.ExchangeTokenResponse>("item/public_token/exchange", request);
        }

        /// <summary>
        /// Rotates the access_token associated with an <see cref="Entity.Item"/>. The endpoint returns a new access_token and immediately invalidates the previous access_token.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>Task&lt;Management.RotateAccessTokenResponse&gt;.</returns>
        public Task<Management.RotateAccessTokenResponse> RotateAccessTokenAsync(Management.RotateAccessTokenRequest request)
        {
            return PostAsync<Management.RotateAccessTokenResponse>("item/access_token/invalidate", request);
        }

        /// <summary>
        /// Updates an access_token from the legacy version of Plaid’s API, you can use method to generate an access_token for the Item that works with the current API.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>Task&lt;Management.UpdateAccessTokenVersionResponse&gt;.</returns>
        public Task<Management.UpdateAccessTokenVersionResponse> UpdateAccessTokenVersion(Management.UpdateAccessTokenVersionRequest request)
        {
            return PostAsync<Management.UpdateAccessTokenVersionResponse>("item/access_token/update_version", request);
        }

        /* Institutions */

        /// <summary>
        /// Retrieves the institutions that match the query parameters.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>Task&lt;Institution.SearchResponse&gt;.</returns>
        public Task<Institution.SearchResponse> FetchInstitutionsAsync(Institution.SearchRequest request)
        {
            return PostAsync<Institution.SearchResponse>("institutions/search", request);
        }

        /// <summary>
        /// Retrieves the institutions that match the id.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>Task&lt;Institution.SearchByIdResponse&gt;.</returns>
        public Task<Institution.SearchByIdResponse> FetchInstitutionByIdAsync(Institution.SearchByIdRequest request)
        {
            return PostAsync<Institution.SearchByIdResponse>("institutions/get_by_id", request);
        }

        /* Income */

        /// <summary>
        /// Retrieves information pertaining to a <see cref="Entity.Item"/>’s income. In addition to the annual income, detailed information will be provided for each contributing income stream (or job).
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>Task&lt;Income.GetIncomeResponse&gt;.</returns>
        public Task<Income.GetIncomeResponse> FetchUserIncomeAsync(Income.GetIncomeRequest request)
        {
            return PostAsync<Income.GetIncomeResponse>("income/get", request);
        }

        /* Auth */

        /// <summary>
        /// Retrieves the bank account and routing numbers associated with an <see cref="Entity.Item"/>’s checking and savings accounts, along with high-level account data and balances.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>Task&lt;Auth.GetAccountInfoResponse&gt;.</returns>
        public Task<Auth.GetAccountInfoResponse> FetchAccountInfoAsync(Auth.GetAccountInfoRequest request)
        {
            return PostAsync<Auth.GetAccountInfoResponse>("auth/get", request);
        }

        /* Balance */

        /// <summary>
        /// Retrieve high-level information about all accounts associated with an <see cref="Entity.Item"/>.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>Task&lt;Balance.GetAccountResponse&gt;.</returns>
        public Task<Balance.GetAccountResponse> FetchAccountAsync(Balance.GetAccountRequest request)
        {
            return PostAsync<Balance.GetAccountResponse>("accounts/get", request);
        }

        /// <summary>
        ///  Retrieves the real-time balance for each of an <see cref="Entity.Item"/>’s accounts.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>Task&lt;Balance.GetBalanceResponse&gt;.</returns>
        public Task<Balance.GetBalanceResponse> FetchAccountBalanceAsync(Balance.GetBalanceRequest request)
        {
            return PostAsync<Balance.GetBalanceResponse>("accounts/balance/get", request);
        }

        /* Categories */

        /// <summary>
        ///  Retrieves detailed information on categories returned by Plaid.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>Task&lt;Category.GetCategoriesResponse&gt;.</returns>
        public Task<Category.GetCategoriesResponse> FetchCategoriesAsync(Category.GetCategoriesRequest request)
        {
            return PostAsync<Category.GetCategoriesResponse>("categories/get", request);
        }

        /* Identity */

        /// <summary>
        /// Retrieves various account holder information on file with the financial institution, including names, emails, phone numbers, and addresses.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>Task&lt;Identity.GetUserIdentityResponse&gt;.</returns>
        public Task<Identity.GetUserIdentityResponse> FetchUserIdentityAsync(Identity.GetUserIdentityRequest request)
        {
            return PostAsync<Identity.GetUserIdentityResponse>("identity/get", request);
        }

        /* Transactions */

        /// <summary>
        ///  Retrieves user-authorized transaction data for credit and depository-type <see cref="Entity.Account"/>.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>Task&lt;Transactions.GetTransactionsResponse&gt;.</returns>
        public Task<Transactions.GetTransactionsResponse> FetchTransactionsAsync(Transactions.GetTransactionsRequest request)
        {
            return PostAsync<Transactions.GetTransactionsResponse>("transactions/get", request);
        }


        /* Stripe */
        /// <summary>
        ///  Exchanges a Link access_token for an Stripe API stripe_bank_account_token.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>Task&lt;Management.StripeTokenResponse&gt;.</returns>
        public Task<Management.StripeTokenResponse> FetchStripeTokenAsync(Management.StripeTokenRequest request)
        {
            return PostAsync<Management.StripeTokenResponse>("processor/stripe/bank_account_token/create", request);
        }


        /* ***** */

        internal string GetEndpoint(string path)
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
            }

            return new UriBuilder()
            {
                Scheme = Uri.UriSchemeHttps,
                Host = $"{subDomain}plaid.com",
                Path = path.Trim(' ', '/', '\\')
            }.Uri.AbsoluteUri;
        }

        internal async Task<TResponse> PostAsync<TResponse>(string path, SerializableContent request) where TResponse : ResponseBase
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
            var line = string.Concat(System.Linq.Enumerable.Repeat('-', 100));
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