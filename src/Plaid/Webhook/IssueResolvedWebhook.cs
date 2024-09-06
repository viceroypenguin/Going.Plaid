namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Webhook notifications are sent only when a subscribed issue is marked as resolved. The payload contains details about the issue at the time of its resolution, focusing on the most essential information.</para>
/// </summary>
public record IssueResolvedWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.Issues;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.IssueResolved;

	/// <summary>
	/// <para>The unique identifier of the connectivity issue.</para>
	/// </summary>
	[JsonPropertyName("issue_id")]
	public string IssueId { get; init; } = default!;

	/// <summary>
	/// <para>A simple description of the error for the end user.</para>
	/// </summary>
	[JsonPropertyName("issue_description")]
	public string IssueDescription { get; init; } = default!;

	/// <summary>
	/// <para>The time when the issue was marked as resolved.</para>
	/// </summary>
	[JsonPropertyName("issue_resolved_at")]
	public DateTimeOffset IssueResolvedAt { get; init; } = default!;

	/// <summary>
	/// <para>The unique identifier of the financial institution involved.</para>
	/// </summary>
	[JsonPropertyName("institution_id")]
	public string InstitutionId { get; init; } = default!;

	/// <summary>
	/// <para>The name of the financial institution involved.</para>
	/// </summary>
	[JsonPropertyName("institution_name")]
	public string InstitutionName { get; init; } = default!;

}
