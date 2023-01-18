namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object representing...</para>
/// </summary>
public record CreditFreddieMacAssetTransaction_VOE_2_5
{
	/// <summary>
	/// <para>Documentation not found in the MISMO model viewer and not provided by Freddie Mac.</para>
	/// </summary>
	[JsonPropertyName("ASSET_TRANSACTION_DETAIL")]
	public Entity.CreditFreddieMacAssetTransactionDetail_VOE_2_5 AssetTransactionDetail { get; init; } = default!;

	/// <summary>
	/// <para>Documentation not found in the MISMO model viewer and not provided by Freddie Mac.</para>
	/// </summary>
	[JsonPropertyName("ASSET_TRANSACTION_DESCRIPTION")]
	public IReadOnlyList<Entity.AssetTransactionDescription> AssetTransactionDescription { get; init; } = default!;
}