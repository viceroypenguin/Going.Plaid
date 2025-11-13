namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when the Check Report are ready to be retrieved. Once this webhook has fired, the report will be available to retrieve for 24 hours.</para>
/// </summary>
public record CraUserCheckReportReadyWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.CheckReport;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.UserCheckReportReady;

	/// <summary>
	/// <para>The <c>user_id</c> corresponding to the user the webhook has fired for. Typically, this ID will come from the <c>/user/create</c> response, when the endpoint is invoked with the <c>with_upgraded_user</c> request field set to <c>true</c>.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string UserId { get; init; } = default!;

	/// <summary>
	/// <para>Specifies a list of products that have successfully been generated for the report.</para>
	/// </summary>
	[JsonPropertyName("successful_products")]
	public IReadOnlyList<Entity.Products>? SuccessfulProducts { get; init; } = default!;

	/// <summary>
	/// <para>Specifies a list of products that have failed to generate for the report. Additional detail on what caused the failure can be found by calling the product /get endpoint.</para>
	/// </summary>
	[JsonPropertyName("failed_products")]
	public IReadOnlyList<Entity.Products>? FailedProducts { get; init; } = default!;

	/// <summary>
	/// <para>A list of <c>item_ids</c> that is included in the Check Report.</para>
	/// </summary>
	[JsonPropertyName("item_ids")]
	public IReadOnlyList<string>? ItemIds { get; init; } = default!;

}
