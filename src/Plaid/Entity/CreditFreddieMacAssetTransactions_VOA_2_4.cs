namespace Going.Plaid.Entity;

/// <summary>
/// <para>Documentation not found in the MISMO model viewer and not provided by Freddie Mac.</para>
/// </summary>
public record CreditFreddieMacAssetTransactions_VOA_2_4
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("ASSET_TRANSACTION")]
	public IReadOnlyList<Entity.CreditFreddieMacAssetTransaction_VOA_2_4> AssetTransaction { get; init; } = default!;
}