namespace Going.Plaid.Entity;

/// <summary>
/// <para>ProfileIdentityName defines the user's first name and last name.</para>
/// </summary>
public record ProfileIdentityName
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
