namespace Going.Plaid.Management
{
	/// <summary>
	/// Represents a response from plaid's '<c>/item/webhook/update</c>' endpoint. The <c>/item/webhook/update</c> endpoint allows you to update the webhook associated with an <see cref="Entity.Item"/>. This request triggers a WEBHOOK_UPDATE_ACKNOWLEDGED webhook. (https://plaid.com/docs/api/#item-webhooks).
	/// </summary>
	/// <seealso cref="Going.Plaid.ResponseBase" />
	public record UpdateWebhookResponse : ResponseBase
	{
		/// <summary>
		/// Gets or sets the item.
		/// </summary>
		public Entity.Item Item { get; init; } = null!;
	}
}
