namespace Going.Plaid.Identity;

/// <summary>
/// <para>IdentityGetResponse defines the response schema for <c>/identity/get</c></para>
/// </summary>
public record IdentityGetResponse : ResponseBase
{
	/// <summary>
	/// <para>The accounts for which Identity data has been requested</para>
	/// </summary>
	[JsonPropertyName("accounts")]
	public IReadOnlyList<Entity.AccountIdentity> Accounts { get; init; } = default!;

	/// <summary>
	/// <para>Metadata about the Item.</para>
	/// </summary>
	[JsonPropertyName("item")]
	public Entity.Item Item { get; init; } = default!;

}
