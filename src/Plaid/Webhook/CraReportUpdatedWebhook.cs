namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when a subscribed CRA report has been updated. Retrieve the updated products by calling the relevant product <c>/get</c> endpoint. A single webhook covers all CRA report-update subscriptions; the <c>successful_products</c>/<c>failed_products</c> fields indicate which products were updated, and the <c>scope</c> field indicates the data the report was computed over.</para>
/// </summary>
public record CraReportUpdatedWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.CraReport;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.CraReportUpdated;

	/// <summary>
	/// <para>The <c>user_id</c> associated with the user whose data is being requested. This is received by calling <c>/user/create</c>.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string UserId { get; init; } = default!;

	/// <summary>
	/// <para>The identifier of the CRA report that was updated. Pass this value to the relevant product <c>/get</c> endpoint to retrieve the updated report.</para>
	/// </summary>
	[JsonPropertyName("report_id")]
	public string? ReportId { get; init; } = default!;

	/// <summary>
	/// <para>Determines whose items are used. <c>PLAID_NETWORK</c> (default) uses the Plaid Network view of the user's profile. <c>CLIENT_USER</c> uses only the items linked by this client.</para>
	/// </summary>
	[JsonPropertyName("scope")]
	public Entity.CraReportScope Scope { get; init; } = default!;

	/// <summary>
	/// <para>Specifies a list of products that have successfully been updated for the report. Call the product <c>/get</c> endpoint to retrieve them.</para>
	/// </summary>
	[JsonPropertyName("successful_products")]
	public IReadOnlyList<Entity.CreditProduct> SuccessfulProducts { get; init; } = default!;

	/// <summary>
	/// <para>Specifies a list of products that have failed to update for the report. Additional detail on what caused the failure can be found by calling the product <c>/get</c> endpoint.</para>
	/// </summary>
	[JsonPropertyName("failed_products")]
	public IReadOnlyList<Entity.CreditProduct> FailedProducts { get; init; } = default!;

	/// <summary>
	/// <para>The timestamp when the products were generated, in ISO 8601 format. Null if there are no successful products.</para>
	/// </summary>
	[JsonPropertyName("generated_time")]
	public DateTimeOffset? GeneratedTime { get; init; } = default!;

	/// <summary>
	/// <para>The reason all products failed to update. Populated only when every requested product failed; null if any product succeeded. For example, <c>NO_ELIGIBLE_ITEMS</c>.</para>
	/// </summary>
	[JsonPropertyName("error_code")]
	public string? ErrorCode { get; init; } = default!;

}
