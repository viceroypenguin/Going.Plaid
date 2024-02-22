namespace Going.Plaid.Profile;

/// <summary>
/// <para>ProfileGetResponse defines the response schema for <c>/profile/get</c></para>
/// </summary>
public record ProfileGetResponse : ResponseBase
{
	/// <summary>
	/// <para>ProfileIdentity defines the identity data permissioned by the end user during the authorization flow.</para>
	/// </summary>
	[JsonPropertyName("identity")]
	public Entity.ProfileIdentity? Identity { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("items")]
	public IReadOnlyList<Entity.ProfileItem> Items { get; init; } = default!;

}
