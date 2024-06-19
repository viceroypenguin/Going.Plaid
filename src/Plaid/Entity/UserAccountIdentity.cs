namespace Going.Plaid.Entity;

/// <summary>
/// <para>UserAccountIdentity defines the identity data permissioned by the end user during the authorization flow.</para>
/// </summary>
public record UserAccountIdentity
{
	/// <summary>
	/// <para>UserAccountIdentityName defines the user's first name and last name.</para>
	/// </summary>
	[JsonPropertyName("name")]
	public Entity.UserAccountIdentityName? Name { get; init; } = default!;

	/// <summary>
	/// <para>UserAccountIdentityAddress defines the user's address.</para>
	/// </summary>
	[JsonPropertyName("address")]
	public Entity.UserAccountIdentityAddress? Address { get; init; } = default!;

	/// <summary>
	/// <para>The user's phone number in <a href="https://en.wikipedia.org/wiki/E.164">E.164</a> format</para>
	/// </summary>
	[JsonPropertyName("phone_number")]
	public string? PhoneNumber { get; init; } = default!;

	/// <summary>
	/// <para>The user's email address.</para>
	/// </summary>
	[JsonPropertyName("email")]
	public string? Email { get; init; } = default!;

	/// <summary>
	/// <para>The user's date of birth.</para>
	/// </summary>
	[JsonPropertyName("date_of_birth")]
	public string? DateOfBirth { get; init; } = default!;

	/// <summary>
	/// <para>The user's social security number.</para>
	/// </summary>
	[JsonPropertyName("ssn")]
	public string? Ssn { get; init; } = default!;

	/// <summary>
	/// <para>The last 4 digits of the user's social security number.</para>
	/// </summary>
	[JsonPropertyName("ssn_last_4")]
	public string? SsnLast4 { get; init; } = default!;

}
