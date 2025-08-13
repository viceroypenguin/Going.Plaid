namespace Going.Plaid.Entity;

/// <summary>
/// <para>Documentation not found in the MISMO model viewer and not provided by Freddie Mac.</para>
/// </summary>
public record AssetHoldings
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("ASSET_HOLDING")]
	public IReadOnlyList<Entity.AssetHolding> AssetHolding { get; init; } = default!;

}
