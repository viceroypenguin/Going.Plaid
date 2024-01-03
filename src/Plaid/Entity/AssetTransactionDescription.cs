namespace Going.Plaid.Entity;

/// <summary>
/// <para>Documentation not found in the MISMO model viewer and not provided by Freddie Mac.</para>
/// </summary>
public record AssetTransactionDescription
{
	/// <summary>
	/// <para>Asset Transaction Description String up to 3 occurances 1 required.</para>
	/// </summary>
	[JsonPropertyName("AssetTransactionDescription")]
	public string Assettransactiondescription { get; init; } = default!;

}
