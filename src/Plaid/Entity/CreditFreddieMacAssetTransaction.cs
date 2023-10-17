namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object representing...</para>
/// </summary>
public record CreditFreddieMacAssetTransaction
{
	/// <summary>
	/// <para>Documentation not found in the MISMO model viewer and not provided by Freddie Mac.</para>
	/// </summary>
	[JsonPropertyName("ASSET_TRANSACTION_DETAIL")]
	public Entity.AssetTransactionDetail AssetTransactionDetail { get; init; } = default!;

	/// <summary>
	/// <para>Documentation not found in the MISMO model viewer and not provided by Freddie Mac.</para>
	/// </summary>
	[JsonPropertyName("ASSET_TRANSACTION_DESCRIPTION")]
	public IReadOnlyList<Entity.AssetTransactionDescription> AssetTransactionDescription { get; init; } = default!;
}