namespace Going.Plaid.Entity;

/// <summary>
/// <para>Documentation not found in the MISMO model viewer and not provided by Freddie Mac.</para>
/// </summary>
public record CreditFreddieMacAsset
{
	/// <summary>
	/// <para>Details about an asset.</para>
	/// </summary>
	[JsonPropertyName("ASSET_DETAIL")]
	public Entity.AssetDetail AssetDetail { get; init; } = default!;

	/// <summary>
	/// <para>Documentation not found in the MISMO model viewer and not provided by Freddie Mac.</para>
	/// </summary>
	[JsonPropertyName("ASSET_OWNERS")]
	public Entity.AssetOwners AssetOwners { get; init; } = default!;

	/// <summary>
	/// <para>Documentation not found in the MISMO model viewer and not provided by Freddie Mac.</para>
	/// </summary>
	[JsonPropertyName("ASSET_HOLDER")]
	public Entity.AssetHolder AssetHolder { get; init; } = default!;

	/// <summary>
	/// <para>Documentation not found in the MISMO model viewer and not provided by Freddie Mac.</para>
	/// </summary>
	[JsonPropertyName("ASSET_TRANSACTIONS")]
	public Entity.CreditFreddieMacAssetTransactions AssetTransactions { get; init; } = default!;

	/// <summary>
	/// <para>Documentation not found in the MISMO model viewer and not provided by Freddie Mac.</para>
	/// </summary>
	[JsonPropertyName("VALIDATION_SOURCES")]
	public Entity.ValidationSources ValidationSources { get; init; } = default!;

}
