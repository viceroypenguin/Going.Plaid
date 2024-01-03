namespace Going.Plaid.Entity;

/// <summary>
/// <para>Documentation not found in the MISMO model viewer and not provided by Freddie Mac.</para>
/// </summary>
public record AssetOwner
{
	/// <summary>
	/// <para>Account Owner Full Name.</para>
	/// </summary>
	[JsonPropertyName("AssetOwnerText")]
	public string? Assetownertext { get; init; } = default!;

}
