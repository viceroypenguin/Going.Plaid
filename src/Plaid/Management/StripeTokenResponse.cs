using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Acklann.Plaid.Management
{
    /// <summary>
    /// Represents a response from plaid's '/processor/stripe/bank_account_token/create' endpoint. Exchange a Link access_token for an Stripe API stripe_bank_account_token.
    /// </summary>
    /// <seealso cref="Acklann.Plaid.ResponseBase" />
    public class StripeTokenResponse : ResponseBase
    {

        /// <summary>
        /// Gets or sets the access token.
        /// </summary>
        /// <value>The access token.</value>
        [JsonProperty("stripe_bank_account_token")]
        public string StripeBankAccountToken { get; set; }
    }
}
