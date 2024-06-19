namespace Going.Plaid.Entity;

/// <summary>
/// <para>UserAccountIdentityName defines the user's first name and last name.</para>
/// </summary>
public record UserAccountIdentityName
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("first_name")]
	public string? FirstName { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("last_name")]
	public string? LastName { get; init; } = default!;

}
