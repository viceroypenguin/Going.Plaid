namespace Going.Plaid.Entity;

/// <summary>
/// <para>Email address information for the associated entity watchlist hit</para>
/// </summary>
public record EntityScreeningHitEmails
{
	/// <summary>
	/// <para>A valid email address.</para>
	/// </summary>
	[JsonPropertyName("email_address")]
	public string EmailAddress { get; init; } = default!;

}
