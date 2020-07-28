namespace Going.Plaid.Management
{
	/// <summary>
	/// Represents a request for plaid's '<c>/item/webhook/update</c>' endpoint. The '<c>/item/webhook/update</c>' endpoint allows you to update the webhook associated with an <see cref="Entity.Item"/>. This request triggers a WEBHOOK_UPDATE_ACKNOWLEDGED webhook. (https://plaid.com/docs/api/#item-webhooks)
	/// </summary>
	/// <seealso cref="Going.Plaid.RequestBase" />
	public class UpdateWebhookRequest : RequestBase
	{
		/// <summary>
		/// Gets or sets the webhook.
		/// </summary>
		/// <value>The webhook.</value>
		public string Webhook { get; set; } = string.Empty;
	}
}
