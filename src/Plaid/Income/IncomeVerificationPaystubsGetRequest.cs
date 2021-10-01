namespace Going.Plaid.Income;

/// <summary>
/// <para>IncomeVerificationPaystubsGetRequest defines the request schema for <c>/income/verification/paystubs/get</c>.</para>
/// </summary>
public partial class IncomeVerificationPaystubsGetRequest : RequestBase
{
	/// <summary>
	/// <para>The ID of the verification for which to get paystub information.</para>
	/// </summary>
	[JsonPropertyName("income_verification_id")]
	public string? IncomeVerificationId { get; set; } = default!;
}