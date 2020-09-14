using System;
using Newtonsoft.Json;

namespace Going.Plaid.Management
{
	/// <summary>
	/// Represents a response from plaid's '<c>/item/get</c>' endpoint. The POST <c>/item/get</c> endpoint returns information about the status of an <see cref="Entity.Item"/>.
	/// </summary>
	/// <seealso cref="Going.Plaid.ResponseBase" />
	public class GetItemResponse : ResponseBase
	{
		/// <summary>
		/// Gets or sets the item.
		/// </summary>
		/// <value>The item.</value>
		public Entity.Item Item { get; set; } = null!;

		/// <summary>
		/// Information about the last transaction, webhook statuses of the Item.
		/// </summary>
		[JsonProperty("status")]
		public ItemStatus Status { get; set; } = null!;

		/// <summary>
		/// Information about the last transaction, webhook statuses of the Item.
		/// </summary>
		public partial class ItemStatus
		{
			/// <summary>
			/// The timestamps of the last successful and failed transactions update for the Item.
			/// </summary>
			[JsonProperty("transactions")]
			public LastTransactionInformation Transactions { get; set; } = null!;

			/// <summary>
			/// Information about the last webhook fired for the Item.
			/// </summary>
			[JsonProperty("last_webhook")]
			public LastWebhook LastWebhook { get; set; } = null!;
		}

		/// <summary>
		/// Information about the last webhook fired for the Item.
		/// </summary>
		public partial class LastWebhook
		{
			/// <summary>
			/// Timestamp of when the webhook was fired.
			/// </summary>
			[JsonProperty("sent_at")]
			public DateTime? SentAt { get; set; }

			/// <summary>
			/// The last webhook code sent
			/// </summary>
			[JsonProperty("code_sent")]
			public string CodeSent { get; set; } = null!;
		}

		/// <summary>
		/// Information about the last successful and failed transactions update for the Item.
		/// </summary>
		public partial class LastTransactionInformation
		{
			/// <summary>
			/// Timestamp of the last successful transactions update for the Item.
			/// </summary>
			[JsonProperty("last_successful_update")]
			public DateTime? LastSuccessfulUpdate { get; set; }

			/// <summary>
			/// Timestamp of the last failed transactions update for the Item.
			/// </summary>
			[JsonProperty("last_failed_update")]
			public DateTime? LastFailedUpdate { get; set; }
		}
	}
}
