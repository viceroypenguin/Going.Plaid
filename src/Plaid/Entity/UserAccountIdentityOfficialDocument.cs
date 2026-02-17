namespace Going.Plaid.Entity;

/// <summary>
/// <para>Official identity document edit statistics.</para>
/// </summary>
public record UserAccountIdentityOfficialDocument
{
	/// <summary>
	/// <para>Edit counts over various time periods.</para>
	/// </summary>
	[JsonPropertyName("ssn")]
	public Entity.UserAccountIdentityEditCounts? Ssn { get; init; } = default!;

}
