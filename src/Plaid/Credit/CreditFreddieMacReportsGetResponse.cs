namespace Going.Plaid.Credit;

/// <summary>
/// <para>CreditFreddieMacReportsGetResponse defines the response schema for <c>/credit/freddie_mac/reports/get</c></para>
/// </summary>
public record CreditFreddieMacReportsGetResponse : ResponseBase
{
	/// <summary>
	/// <para>Verification of Assets Report</para>
	/// </summary>
	[JsonPropertyName("VOA")]
	public Entity.CreditFreddieMacVerificationOfAssets_VOA_2_4 Voa { get; init; } = default!;

	/// <summary>
	/// <para>Verification of Employment Report</para>
	/// </summary>
	[JsonPropertyName("VOE")]
	public Entity.CreditFreddieVerificationOfEmployment_VOE_2_5? Voe { get; init; } = default!;
}