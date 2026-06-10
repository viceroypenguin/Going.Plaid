namespace Going.Plaid.Entity;

/// <summary>
/// <para>Documentation not found in the MISMO model viewer and not provided by Freddie Mac.</para>
/// </summary>
public record AssetOwners
{
	/// <summary>
	/// <para>A list of up to 4 account owners' full names.</para>
	/// </summary>
	[JsonPropertyName("ASSET_OWNER")]
	public IReadOnlyList<Entity.AssetOwner> AssetOwner { get; init; } = default!;

}
