namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when generation finishes for a CRA report requested via <c>/cra/report/create</c> or a Link session configured with <c>cra_report_parameter</c>, whether every requested product was generated, only some were, or none were. <c>successful_products</c> and <c>failed_products</c> indicate which products were generated, and <c>error_code</c> is populated when every product failed. Call <c>/cra/report/get</c> for the generated products and for error details on failed products.</para>
/// </summary>
public record CraReportReadyWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.CraReport;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.CraReportReady;

	/// <summary>
	/// <para>The <c>user_id</c> associated with the user whose data is being requested. This is received by calling <c>/user/create</c>.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string UserId { get; init; } = default!;

	/// <summary>
	/// <para>The <c>client_user_id</c> you supplied for this user when calling <c>/user/create</c>. <c>null</c> if no <c>client_user_id</c> is associated with the user.</para>
	/// </summary>
	[JsonPropertyName("client_user_id")]
	public string? ClientUserId { get; init; } = default!;

	/// <summary>
	/// <para>The identifier of the CRA report. Pass this value to <c>/cra/report/get</c> to retrieve the report.</para>
	/// </summary>
	[JsonPropertyName("report_id")]
	public string? ReportId { get; init; } = default!;

	/// <summary>
	/// <para>The <c>client_report_id</c> you supplied when requesting the report, if any.</para>
	/// </summary>
	[JsonPropertyName("client_report_id")]
	public string? ClientReportId { get; init; } = default!;

	/// <summary>
	/// <para>Determines whose items are used. <c>PLAID_NETWORK</c> (default) uses the Plaid Network view of the user's profile. <c>CLIENT_USER</c> uses only the items linked by this client.</para>
	/// </summary>
	[JsonPropertyName("scope")]
	public Entity.CraReportScope Scope { get; init; } = default!;

	/// <summary>
	/// <para>Specifies a list of products that have successfully been generated for the report.</para>
	/// </summary>
	[JsonPropertyName("successful_products")]
	public IReadOnlyList<Entity.CreditProduct> SuccessfulProducts { get; init; } = default!;

	/// <summary>
	/// <para>Specifies a list of products that have failed to generate for the report. Additional detail on what caused the failure can be found in the product's <c>errors</c> when calling <c>/cra/report/get</c>.</para>
	/// </summary>
	[JsonPropertyName("failed_products")]
	public IReadOnlyList<Entity.CreditProduct> FailedProducts { get; init; } = default!;

	/// <summary>
	/// <para>The timestamp when the products were generated, in ISO 8601 format. Null if there are no successful products.</para>
	/// </summary>
	[JsonPropertyName("generated_time")]
	public DateTimeOffset? GeneratedTime { get; init; } = default!;

	/// <summary>
	/// <para>The reason every product in a CRA report failed to generate. <c>null</c> when at least one product succeeded.</para>
	/// </summary>
	[JsonPropertyName("error_code")]
	public Entity.CraReportErrorCode? ErrorCode { get; init; } = default!;

}
