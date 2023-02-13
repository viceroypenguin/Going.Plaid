namespace Going.Plaid.Entity;

/// <summary>
/// <para>Verification of Employment Report</para>
/// </summary>
public record CreditFreddieVerificationOfEmployment_VOE_2_5
{
	/// <summary>
	/// <para>An object representing a Verification of Employment report.</para>
	/// </summary>
	[JsonPropertyName("DEAL")]
	public Entity.CreditFreddieVerificationOfEmploymentDeal_VOE_2_5 Deal { get; init; } = default!;

	/// <summary>
	/// <para>The Verification Of Employment (VOE) schema version.</para>
	/// </summary>
	[JsonPropertyName("SchemaVersion")]
	public decimal Schemaversion { get; init; } = default!;
}