namespace Going.Plaid.Credit;

/// <summary>
/// <para>CreditFreddieMacReportsGetResponse defines the response schema for <c>/credit/freddie_mac/reports/get</c></para>
/// </summary>
public record CreditFreddieMacReportsGetResponse : ResponseBase
{
	/// <summary>
	/// <para>An object representing an Asset Report with Freddie Mac schema.</para>
	/// </summary>
	[JsonPropertyName("DEAL")]
	public Entity.CreditFreddieMacVerificationOfAssetsDeal Deal { get; init; } = default!;

	/// <summary>
	/// <para>The Verification Of Assets (VOA) schema version.</para>
	/// </summary>
	[JsonPropertyName("SchemaVersion")]
	public decimal Schemaversion { get; init; } = default!;
}