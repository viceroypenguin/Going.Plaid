namespace Going.Plaid.Entity;

/// <summary>
/// <para>Documentation not found in the MISMO model viewer and not provided by Freddie Mac.</para>
/// </summary>
public record CreditFreddieMacVerificationOfAssetResponse_VOE_2_5
{
	/// <summary>
	/// <para>Documentation not found in the MISMO model viewer and not provided by Freddie Mac.</para>
	/// </summary>
	[JsonPropertyName("ASSETS")]
	public Entity.CreditFreddieMacAssets_VOE_2_5 Assets { get; init; } = default!;
}