namespace Going.Plaid.Entity;

/// <summary>
/// <para>Email address information for the associated entity watchlist hit</para>
/// </summary>
public record EntityScreeningHitEmails
{
	/// <summary>
	/// <para>A valid email address. Must not have leading or trailing spaces and address must be RFC compliant. For more information, see <a href="https://datatracker.ietf.org/doc/html/rfc3696">RFC 3696</a>.</para>
	/// </summary>
	[JsonPropertyName("email_address")]
	public string EmailAddress { get; init; } = default!;

}
