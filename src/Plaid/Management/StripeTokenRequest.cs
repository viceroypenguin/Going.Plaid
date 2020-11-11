﻿using System.Text.Json.Serialization;

namespace Going.Plaid.Management
{
	/// <summary>
	/// Represents a request for plaid's '<c>/processor/stripe/bank_account_token/create</c>' endpoint. Exchange a Link access_token for an Stripe API stripe_bank_account_token and request_id. 
	/// </summary>
	/// <seealso cref="RequestBase" />
	public class StripeTokenRequest : RequestBase
	{
		/// <summary>
		/// The account id.
		/// </summary>
		[JsonPropertyName("account_id")]
		public string AccountId { get; set; } = string.Empty;
	}
}
