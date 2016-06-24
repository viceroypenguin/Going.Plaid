using Newtonsoft.Json;
using System;
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
            _serializerSettings = new JsonSerializerSettings()
            {
                DateFormatString = "yyyy-MM-dd",
                Formatting = Formatting.Indented
            };
#else
            _serializerSettings = new JsonSerializerSettings() { DateFormatString = "yyyy-MM-dd" };
#endif
        }

        protected const string ContentType = "application/json";

        [JsonProperty("secret")]
        protected string Secret { get; set; }

        [JsonProperty("client_id")]
        protected string ClientId { get; set; }

        [JsonProperty("access_token")]
        protected string AccessToken { get; set; }

        protected async Task<T> Deserialize<T>(HttpResponseMessage response) where T : Contract.PlaidResponseBase, new()
        {
            using (response)
            {
                string responseBody = await response.Content?.ReadAsStringAsync();
#if DEBUG
                System.Diagnostics.Debug.WriteLine("response");
                System.Diagnostics.Debug.WriteLine("----------------");
                System.Diagnostics.Debug.WriteLine(responseBody);
#endif
                if (response.IsSuccessStatusCode)
                {
                    var result = JsonConvert.DeserializeObject<T>(responseBody);
                    result.StatusCode = response.StatusCode;
                    return result;
                }
                else throw new HttpRequestException(response.ReasonPhrase);
            }
        }

        #region Private Members
        private readonly JsonSerializerSettings _serializerSettings;
        #endregion
    }
}