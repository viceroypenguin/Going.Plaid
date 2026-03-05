namespace Going.Plaid.Entity;

/// <summary>
/// <para>WHOIS metadata for the business website domain.</para>
/// </summary>
public record BusinessWhoisRecord
{
	/// <summary>
	/// <para>An ISO8601 formatted timestamp.</para>
	/// </summary>
	[JsonPropertyName("domain_created_at")]
	public DateTimeOffset? DomainCreatedAt { get; init; } = default!;

	/// <summary>
	/// <para>An ISO8601 formatted timestamp.</para>
	/// </summary>
	[JsonPropertyName("domain_updated_at")]
	public DateTimeOffset? DomainUpdatedAt { get; init; } = default!;

	/// <summary>
	/// <para>An ISO8601 formatted timestamp.</para>
	/// </summary>
	[JsonPropertyName("domain_expires_at")]
	public DateTimeOffset? DomainExpiresAt { get; init; } = default!;

	/// <summary>
	/// <para>Domain registrar.</para>
	/// </summary>
	[JsonPropertyName("registrar")]
	public string? Registrar { get; init; } = default!;

}
