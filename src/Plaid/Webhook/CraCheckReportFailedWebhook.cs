namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when a Check Report has failed to generate. To get more details, call <c>/user/items/get</c> and check for non-null <c>error</c> objects on the associated Items in the response. These <c>error</c> objects will contain more details on why the Item is in an error state and how to resolve it. After resolving the errors, you can try to re-generate the report.</para>
/// </summary>
public record CraCheckReportFailedWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.CheckReport;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.CheckReportFailed;

	/// <summary>
	/// <para>The <c>user_id</c> corresponding to the user the webhook has fired for.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string UserId { get; init; } = default!;

	/// <summary>
	/// <para>Details on why the Check Report failed and how to resolve it.</para>
	/// </summary>
	[JsonPropertyName("error")]
	public Entity.PlaidError? Error { get; init; } = default!;

	/// <summary>
	/// <para>A list of Items that the end user can repair via Link <a href="https://plaid.com/docs/link/update-mode">update mode</a>. Empty when no Item is user-repairable. After repairing these Items, call <c>/cra/check_report/create</c> to regenerate the report.</para>
	/// </summary>
	[JsonPropertyName("repairable_items")]
	public IReadOnlyList<Entity.CheckReportRepairableItem>? RepairableItems { get; init; } = default!;

	/// <summary>
	/// <para>Specifies a list of products that failed to generate for the report. Populated when generation was attempted and all requested products failed. Additional detail on what caused the failure can be found by calling the product /get endpoint.</para>
	/// </summary>
	[JsonPropertyName("failed_products")]
	public IReadOnlyList<Entity.Products>? FailedProducts { get; init; } = default!;

	/// <summary>
	/// <para>A list of <c>item_ids</c> included in the Check Report. Access to this field is in closed beta.</para>
	/// </summary>
	[JsonPropertyName("item_ids")]
	public IReadOnlyList<string>? ItemIds { get; init; } = default!;

}
