using Newtonsoft.Json;

namespace Gigobyte.Plaid.Contract
{
    /// <summary>
    /// Represents a response message of the Plaid Connect API.
    /// </summary>
    [JsonObject]
    public class PlaidConnectResponse
    {
        /// <summary>
        /// Gets or sets the user's accounts.
        /// </summary>
        /// <value>The accounts.</value>
        [JsonProperty("accounts")]
        public Account[] Accounts { get; set; }

        /// <summary>
        /// Gets or sets the user's transactions.
        /// </summary>
        /// <value>The transactions.</value>
        [JsonProperty("transactions")]
        public Transaction[] Transactions { get; set; }

        /// <summary>
        /// Gets or sets the access token.
        /// </summary>
        /// <value>The access token.</value>
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("mfa")]
        public Mfa[] Mfa { get; set; }

        /// <summary>
        /// Gets or sets the MFA type.
        /// </summary>
        /// <value>The type.</value>
        [JsonProperty("type")]
        public string MfaTypeId { get; set; }

        /// <summary>
        /// Gets the type of the MFA type.
        /// </summary>
        /// <value>The type of the MFA.</value>
        public MfaType MfaType
        {
            get { return MfaTypeId.AsMfaType(); }
        }

        /// <summary>
        /// Gets or sets the HTTP status code.
        /// </summary>
        /// <value>The HTTP status code.</value>
        public System.Net.HttpStatusCode StatusCode { get; set; }
    }
}