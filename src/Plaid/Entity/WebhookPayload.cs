using System;
using System.Collections.Generic;
using System.Text;
using Going.Plaid.Exceptions;
using Newtonsoft.Json;

namespace Going.Plaid.Entity
{
	/// <summary>
	/// Represents the object Plaid will send to the Webhook
	/// URL.
	/// </summary>
	public class WebhookPayload
	{
		/// <summary>
		/// Represents which type of webhook is being delivered.
		/// </summary>
		[JsonProperty("webhook_type")]
		public WebhookType WebhookType { get; set; }

		/// <summary>
		/// Represents additional information about the webhook payload
		/// </summary>
		[JsonProperty("webhook_code")]
		public WebhookCode WebhookCode { get; set; }

		/// <summary>
		/// The identifier of the <see cref="Item"/> for which this 
		/// webhook payload is triggered.
		/// </summary>
		[JsonProperty("item_id")]
		public string ItemId { get; set; } = null!;

		/// <summary>
		/// Additional details about the error for which this webhook
		/// is triggered.
		/// </summary>
		[JsonProperty("error")]
		public PlaidException Error { get; set; } = null!;

		/// <summary>
		/// The number of new transactions available.
		/// </summary>
		[JsonProperty("new_transactions")]
		public int NewTransactions { get; set; }

		/// <summary>
		/// The list of transactions that have been removed by the Bank.
		/// </summary>
		[JsonProperty("removed_transactions")]
		public IReadOnlyList<string> RemovedTransactions { get; set; } = Array.Empty<string>();
	}
}
