namespace Going.Plaid.UserAccount;

/// <summary>
/// <para>UserAccountSessionGetResponse defines the response schema for <c>/user_account/session/get</c></para>
/// </summary>
public record UserAccountSessionGetResponse : ResponseBase
{
	/// <summary>
	/// <para>UserAccountIdentity defines the identity data permissioned by the end user during the authorization flow.</para>
	/// </summary>
	[JsonPropertyName("identity")]
	public Entity.UserAccountIdentity? Identity { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("items")]
	public IReadOnlyList<Entity.UserAccountItem> Items { get; init; } = default!;

}
