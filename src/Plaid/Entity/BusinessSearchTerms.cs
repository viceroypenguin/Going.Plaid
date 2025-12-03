namespace Going.Plaid.Entity;

/// <summary>
/// <para>The business information that was used to perform the verification search</para>
/// </summary>
public record BusinessSearchTerms
{
	/// <summary>
	/// <para>The name of the business. Must have at least one character and a maximum length of 500 characters.</para>
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; init; } = default!;

	/// <summary>
	/// <para>Physical address of a business in response</para>
	/// </summary>
	[JsonPropertyName("address")]
	public Entity.BusinessSearchTermsAddress Address { get; init; } = default!;

	/// <summary>
	/// <para>An 'http' or 'https' URL (must begin with either of those).</para>
	/// </summary>
	[JsonPropertyName("website")]
	public string? Website { get; init; } = default!;

	/// <summary>
	/// <para>A phone number in E.164 format.</para>
	/// </summary>
	[JsonPropertyName("phone_number")]
	public string? PhoneNumber { get; init; } = default!;

	/// <summary>
	/// <para>A valid email address. Must not have leading or trailing spaces and address must be RFC compliant. For more information, see <a href="https://datatracker.ietf.org/doc/html/rfc3696">RFC 3696</a>.</para>
	/// </summary>
	[JsonPropertyName("email_address")]
	public string? EmailAddress { get; init; } = default!;

}
