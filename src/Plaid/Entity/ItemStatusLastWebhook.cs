namespace Going.Plaid.Entity;

/// <summary>
/// <para>Information about the last webhook fired for the Item.</para>
/// </summary>
public record ItemStatusLastWebhook
{
	/// <summary>
	/// <para>ISO 8601 timestamp of when the webhook was fired.</para>
	/// </summary>
	[JsonPropertyName("sent_at")]
	public DateTimeOffset? SentAt { get; init; } = default!;

	/// <summary>
	/// <para>The last webhook code sent.</para>
	/// </summary>
	[JsonPropertyName("code_sent")]
	public string? CodeSent { get; init; } = default!;
}