namespace Going.Plaid.Entity;

/// <summary>
/// <para>Email address information for the associated entity watchlist hit</para>
/// </summary>
public record EntityScreeningHitEmails
{
	/// <summary>
	/// <para>A valid email address. Must not have leading or trailing spaces.</para>
	/// </summary>
	[JsonPropertyName("email_address")]
	public string EmailAddress { get; init; } = default!;

}
