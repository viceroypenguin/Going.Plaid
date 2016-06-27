using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Gigobyte.Plaid
{
    public abstract class PlaidClientBase
    {
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

        protected const string ContentType = "application/json";

        protected readonly JsonSerializerSettings SerializerSettings;

        [JsonProperty("secret")]
        protected string Secret { get; set; }

        [JsonProperty("client_id")]
        protected string ClientId { get; set; }

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
                System.Diagnostics.Debug.WriteLine("response");
                System.Diagnostics.Debug.WriteLine("----------");
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