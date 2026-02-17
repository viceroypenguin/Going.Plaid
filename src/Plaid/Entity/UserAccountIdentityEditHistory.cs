namespace Going.Plaid.Entity;

/// <summary>
/// <para>Statistics tracking the number of edits made to identity fields over various time periods.</para>
/// </summary>
public record UserAccountIdentityEditHistory
{
	/// <summary>
	/// <para>Edit counts over various time periods.</para>
	/// </summary>
	[JsonPropertyName("name")]
	public Entity.UserAccountIdentityEditCounts? Name { get; init; } = default!;

	/// <summary>
	/// <para>Edit counts over various time periods.</para>
	/// </summary>
	[JsonPropertyName("address")]
	public Entity.UserAccountIdentityEditCounts? Address { get; init; } = default!;

	/// <summary>
	/// <para>Edit counts over various time periods.</para>
	/// </summary>
	[JsonPropertyName("email")]
	public Entity.UserAccountIdentityEditCounts? Email { get; init; } = default!;

	/// <summary>
	/// <para>Edit counts over various time periods.</para>
	/// </summary>
	[JsonPropertyName("date_of_birth")]
	public Entity.UserAccountIdentityEditCounts? DateOfBirth { get; init; } = default!;

	/// <summary>
	/// <para>Official identity document edit statistics.</para>
	/// </summary>
	[JsonPropertyName("official_document")]
	public Entity.UserAccountIdentityOfficialDocument? OfficialDocument { get; init; } = default!;

}
