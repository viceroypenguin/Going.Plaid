namespace Going.Plaid.Entity;

/// <summary>
/// <para>Verification of Assets Report</para>
/// </summary>
public record CreditFreddieMacVerificationOfAssets_VOA_2_4
{
	/// <summary>
	/// <para>An object representing an Asset Report with Freddie Mac schema.</para>
	/// </summary>
	[JsonPropertyName("DEAL")]
	public Entity.CreditFreddieMacVerificationOfAssetsDeal_VOA_2_4 Deal { get; init; } = default!;

	/// <summary>
	/// <para>The Verification Of Assets (VOA) schema version.</para>
	/// </summary>
	[JsonPropertyName("SchemaVersion")]
	public decimal Schemaversion { get; init; } = default!;
}