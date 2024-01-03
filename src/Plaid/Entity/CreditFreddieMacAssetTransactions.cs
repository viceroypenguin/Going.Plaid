namespace Going.Plaid.Entity;

/// <summary>
/// <para>Documentation not found in the MISMO model viewer and not provided by Freddie Mac.</para>
/// </summary>
public record CreditFreddieMacAssetTransactions
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("ASSET_TRANSACTION")]
	public IReadOnlyList<Entity.CreditFreddieMacAssetTransaction> AssetTransaction { get; init; } = default!;

}
