namespace Going.Plaid.Entity;

/// <summary>
/// <para>Information about the last webhook fired for the Item.</para>
/// </summary>
public record ItemStatusLastWebhook
{
	/// <summary>
	/// <para><a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> timestamp of when the webhook was fired.</para>
	/// </summary>
	[JsonPropertyName("sent_at")]
	public DateTimeOffset? SentAt { get; init; } = default!;

	/// <summary>
	/// <para>The last webhook code sent.</para>
	/// </summary>
	[JsonPropertyName("code_sent")]
	public string? CodeSent { get; init; } = default!;
}