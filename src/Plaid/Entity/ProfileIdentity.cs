namespace Going.Plaid.Entity;

/// <summary>
/// <para>ProfileIdentity defines the identity data permissioned by the end user during the authorization flow.</para>
/// </summary>
public record ProfileIdentity
{
	/// <summary>
	/// <para>ProfileIdentityName defines the user's first name and last name.</para>
	/// </summary>
	[JsonPropertyName("name")]
	public Entity.ProfileIdentityName? Name { get; init; } = default!;

	/// <summary>
	/// <para>ProfileIdentityAddress defines the user's address.</para>
	/// </summary>
	[JsonPropertyName("address")]
	public Entity.ProfileIdentityAddress? Address { get; init; } = default!;

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
