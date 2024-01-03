namespace Going.Plaid.Entity;

/// <summary>
/// <para>Documentation not found in the MISMO model viewer and not provided by Freddie Mac.</para>
/// </summary>
public record VerificationOfAssetResponse
{
	/// <summary>
	/// <para>Documentation not found in the MISMO model viewer and not provided by Freddie Mac.</para>
	/// </summary>
	[JsonPropertyName("ASSETS")]
	public Entity.CreditFreddieMacAssets Assets { get; init; } = default!;

}
