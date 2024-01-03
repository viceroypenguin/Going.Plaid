namespace Going.Plaid.Identity;

/// <summary>
/// <para>IdentityMatchResponse defines the response schema for <c>/identity/match</c></para>
/// </summary>
public record IdentityMatchResponse : ResponseBase
{
	/// <summary>
	/// <para>The accounts for which Identity match has been requested</para>
	/// </summary>
	[JsonPropertyName("accounts")]
	public IReadOnlyList<Entity.AccountIdentityMatchScore> Accounts { get; init; } = default!;

	/// <summary>
	/// <para>Metadata about the Item.</para>
	/// </summary>
	[JsonPropertyName("item")]
	public Entity.Item Item { get; init; } = default!;

}
