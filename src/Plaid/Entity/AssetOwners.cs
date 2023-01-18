namespace Going.Plaid.Entity;

/// <summary>
/// <para>Documentation not found in the MISMO model viewer and not provided by Freddie Mac.</para>
/// </summary>
public record AssetOwners
{
	/// <summary>
	/// <para>Multiple Occurances of Account Owners Full Name up to 4.</para>
	/// </summary>
	[JsonPropertyName("ASSET_OWNER")]
	public IReadOnlyList<Entity.AssetOwner> AssetOwner { get; init; } = default!;
}