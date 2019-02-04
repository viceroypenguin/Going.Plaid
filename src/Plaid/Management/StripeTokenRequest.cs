using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Acklann.Plaid.Management
{
    /// <summary>
    /// Represents a request for plaid's '/processor/stripe/bank_account_token/create' endpoint. Exchange a Link access_token for an Stripe API stripe_bank_account_token and request_id. 
    /// </summary>
    /// <seealso cref="Acklann.Plaid.SerializableContent" />
    public class StripeTokenRequest : SerializableContent
    {
        /// <summary>
        /// Gets or sets the access_token.
        /// </summary>
        /// <value>The access token.</value>
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// Gets or sets the client identifier.
        /// </summary>
        /// <value>The client identifier.</value>
        [JsonProperty("client_id")]
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or sets the secret.
        /// </summary>
        /// <value>The secret.</value>
        [JsonProperty("secret")]
        public string Secret { get; set; }


        /// <summary>
        /// Gets or sets the account id.
        /// </summary>
        /// <value>The account id.</value>
        [JsonProperty("account_id")]
        public string AccountId { get; set; }
    }
}
