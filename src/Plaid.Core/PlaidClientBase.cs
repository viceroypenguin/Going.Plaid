using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Gigobyte.Plaid
{
    /// <summary>
    /// Reprsents an base abstract for making Plaid API request.
    /// </summary>
    public abstract class PlaidClientBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlaidClientBase"/> class.
        /// </summary>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="secret">The secret.</param>
        public PlaidClientBase(string clientId, string secret)
        {
            Secret = secret;
            ClientId = clientId;
#if DEBUG
            SerializerSettings = new JsonSerializerSettings()
            {
                DateFormatString = "yyyy-MM-dd",
                Formatting = Formatting.Indented
            };
#else
            SerializerSettings = new JsonSerializerSettings() { DateFormatString = "yyyy-MM-dd" };
#endif
        }

        /// <summary>
        /// The default HTTP content type.
        /// </summary>
        protected const string ContentType = "application/json";

        /// <summary>
        /// The default JSON serializer settings.
        /// </summary>
        protected readonly JsonSerializerSettings SerializerSettings;

        /// <summary>
        /// Gets or sets the your secret.
        /// </summary>
        /// <value>
        /// The secret.
        /// </value>
        [JsonProperty("secret")]
        protected string Secret { get; set; }

        /// <summary>
        /// Gets or sets the your client id.
        /// </summary>
        /// <value>
        /// The client id.
        /// </value>
        [JsonProperty("client_id")]
        protected string ClientId { get; set; }

        /// <summary>
        /// Gets or sets the access token.
        /// </summary>
        /// <value>
        /// The access token.
        /// </value>
        [JsonProperty("access_token")]
        protected string AccessToken { get; set; }

        /// <summary>
        /// Deserialize the response message to the specified type.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="response">The response.</param>
        /// <returns>Task&lt;T&gt;.</returns>
        /// <exception cref="Exceptions.PlaidException"></exception>
        protected async Task<T> Deserialize<T>(HttpResponseMessage response) where T : Contract.PlaidResponseBase, new()
        {
            using (response)
            {
                string responseBody = await response.Content?.ReadAsStringAsync();
#if DEBUG
                System.Diagnostics.Debug.WriteLine("{0}\nRESPONSE\n{0}", string.Concat(System.Linq.Enumerable.Repeat("=", 7)));
                System.Diagnostics.Debug.WriteLine(responseBody);
#endif
                if (response.IsSuccessStatusCode)
                {
                    var result = JsonConvert.DeserializeObject<T>(responseBody, SerializerSettings);
                    result.StatusCode = response.StatusCode;
                    return result;
                }
                else
                {
                    var json = JToken.Parse(responseBody);
                    throw new Exceptions.PlaidException($"({json["message"].Value<string>().ToUpper()}) {json["resolve"].Value<string>()}", json["code"].Value<int>());
                }
            }
        }
    }
}