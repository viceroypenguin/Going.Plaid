namespace Going.Plaid.Webhook;

/// <summary>
/// <para>The webhook of type <c>PARTNER</c> and code <c>END_CUSTOMER_OAUTH_STATUS_UPDATED</c> will be fired when a partner's end customer has an update on their OAuth registration status with an institution.</para>
/// </summary>
public record PartnerEndCustomerOAuthStatusUpdatedWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.Partner;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.EndCustomerOauthStatusUpdated;

	/// <summary>
	/// <para>The client ID of the end customer</para>
	/// </summary>
	[JsonPropertyName("end_customer_client_id")]
	public string EndCustomerClientId { get; init; } = default!;

	/// <summary>
	/// <para>The institution ID</para>
	/// </summary>
	[JsonPropertyName("institution_id")]
	public string InstitutionId { get; init; } = default!;

	/// <summary>
	/// <para>The institution name</para>
	/// </summary>
	[JsonPropertyName("institution_name")]
	public string InstitutionName { get; init; } = default!;

	/// <summary>
	/// <para>The OAuth status of the update</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.PartnerEndCustomerOAuthStatusUpdatedValues Status { get; init; } = default!;

}
