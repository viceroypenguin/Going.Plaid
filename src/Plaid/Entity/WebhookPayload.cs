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
		public WebhookType WebhookType { get; init; }

		/// <summary>
		/// Represents additional information about the webhook payload
		/// </summary>
		[JsonProperty("webhook_code")]
		public WebhookCode WebhookCode { get; init; }

		/// <summary>
		/// The <see cref="Item.Id"/> of the <see cref="Item"/> associated 
		/// with this webhook, warning, or error
		/// </summary>
		[JsonProperty("item_id")]
		public string? ItemId { get; init; }

		/// <summary>
		/// Additional details about the error for which this webhook
		/// is triggered.
		/// </summary>
		[JsonProperty("error")]
		public PlaidException? Error { get; init; }

		#region ITEM Properties
		/// <summary>
		/// The new webhook URL
		/// </summary>
		[JsonProperty("new_webhook_url")]
		public string? NewWebhookUrl { get; init; }

		/// <summary>
		/// The date and time at which the <see cref="Item"/>'s access consent will expire.
		/// </summary>
		[JsonProperty("consent_expiration_time")]
		public DateTime? ConsentExpirationTime { get; init; }
		#endregion

		#region TRANSACTIONS Properties
		/// <summary>
		/// The number of new transactions detected since the last time this webhook was fired.
		/// </summary>
		[JsonProperty("new_transactions")]
		public int NewTransactionsCount { get; init; }

		/// <summary>
		/// The list of transactions that have been removed by the Bank.
		/// </summary>
		[JsonProperty("removed_transactions")]
		public IReadOnlyList<string> RemovedTransactions { get; init; } = Array.Empty<string>();
		#endregion

		#region AUTH Properties
		/// <summary>
		/// The <see cref="Account.AccountId"/> of the <see cref="Account"/> 
		/// associated with the webhook
		/// </summary>
		[JsonProperty("account_id")]
		public string? AccountId { get; init; }
		#endregion

		#region HOLDINGS Properties
		/// <summary>
		/// The number of new holdings reported since the last time this webhook was fired.
		/// </summary>
		[JsonProperty("new_holdings")]
		public int? NewHoldingsCount { get; init; }

		/// <summary>
		/// The number of updated holdings reported since the last time this webhook was fired.
		/// </summary>
		[JsonProperty("updated_holdings")]
		public int? UpdatedHoldingsCount { get; init; }
		#endregion

		#region INVESTMENTS_TRANSACTIONS Properties
		/// <summary>
		/// The number of new transactions reported since the last time this webhook was fired.
		/// </summary>
		[JsonProperty("new_investments_transactions")]
		public int? NewInvestmentsTransactionsCount { get; init; }

		/// <summary>
		/// The number of canceled transactions reported since the last time this webhook was fired.
		/// </summary>
		[JsonProperty("canceled_investments_transactions")]
		public int? CanceledInvestmentsTransactionsCount { get; init; }
		#endregion
	}
}
