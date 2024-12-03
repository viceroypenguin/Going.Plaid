namespace Going.Plaid.Income;

/// <summary>
/// <para>IncomeVerificationTaxformsGetRequest defines the request schema for <c>/income/verification/taxforms/get</c></para>
/// </summary>
public partial class IncomeVerificationTaxformsGetRequest : RequestBase
{
	/// <summary>
	/// <para>The ID of the verification.</para>
	/// </summary>
	[JsonPropertyName("income_verification_id")]
	[Obsolete]
	public string? IncomeVerificationId { get; set; } = default!;

}
