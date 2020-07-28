using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Going.Plaid.Management
{
	/// <summary>
	/// Represents a request for plaid's '<c>/processor/stripe/bank_account_token/create</c>' endpoint. Exchange a Link access_token for an Stripe API stripe_bank_account_token and request_id. 
	/// </summary>
	/// <seealso cref="Going.Plaid.SerializableContent" />
	public class StripeTokenRequest : SerializableContent
	{
		/// <summary>
		/// The access_token.
		/// </summary>
		[JsonProperty("access_token")]
		public string AccessToken { get; set; } = string.Empty;

		/// <summary>
		/// The client identifier.
		/// </summary>
		[JsonProperty("client_id")]
		public string ClientId { get; set; } = string.Empty;

		/// <summary>
		/// The secret.
		/// </summary>
		[JsonProperty("secret")]
		public string Secret { get; set; } = string.Empty;


		/// <summary>
		/// The account id.
		/// </summary>
		[JsonProperty("account_id")]
		public string AccountId { get; set; } = string.Empty;
	}
}
