using System;
using System.Text.Json.Serialization;

namespace Going.Plaid.Management
{
	/// <summary>
	/// Represents a response from plaid's '<c>/item/get</c>' endpoint. The POST <c>/item/get</c> endpoint returns information about the status of an <see cref="Entity.Item"/>.
	/// </summary>
	/// <seealso cref="Going.Plaid.ResponseBase" />
	public record GetItemResponse : ResponseBase
	{
		/// <summary>
		/// Gets or sets the item.
		/// </summary>
		/// <value>The item.</value>
		public Entity.Item Item { get; init; } = null!;

		/// <summary>
		/// Information about the last transaction, webhook statuses of the Item.
		/// </summary>
		[JsonPropertyName("status")]
		public ItemStatus Status { get; init; } = null!;

		/// <summary>
		/// Information about the last transaction, webhook statuses of the Item.
		/// </summary>
		public partial class ItemStatus
		{
			/// <summary>
			/// The timestamps of the last successful and failed transactions update for the Item.
			/// </summary>
			[JsonPropertyName("transactions")]
			public LastTransactionInformation Transactions { get; init; } = null!;

			/// <summary>
			/// Information about the last webhook fired for the Item.
			/// </summary>
			[JsonPropertyName("last_webhook")]
			public LastWebhook LastWebhook { get; init; } = null!;
		}

		/// <summary>
		/// Information about the last webhook fired for the Item.
		/// </summary>
		public partial class LastWebhook
		{
			/// <summary>
			/// Timestamp of when the webhook was fired.
			/// </summary>
			[JsonPropertyName("sent_at")]
			public DateTime? SentAt { get; init; }

			/// <summary>
			/// The last webhook code sent
			/// </summary>
			[JsonPropertyName("code_sent")]
			public string CodeSent { get; init; } = null!;
		}

		/// <summary>
		/// Information about the last successful and failed transactions update for the Item.
		/// </summary>
		public partial class LastTransactionInformation
		{
			/// <summary>
			/// Timestamp of the last successful transactions update for the Item.
			/// </summary>
			[JsonPropertyName("last_successful_update")]
			public DateTime? LastSuccessfulUpdate { get; init; }

			/// <summary>
			/// Timestamp of the last failed transactions update for the Item.
			/// </summary>
			[JsonPropertyName("last_failed_update")]
			public DateTime? LastFailedUpdate { get; init; }
		}
	}
}
