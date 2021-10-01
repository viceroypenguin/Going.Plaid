namespace Going.Plaid.Income;

/// <summary>
/// <para>IncomeVerificationPaystubGetRequest defines the request schema for <c>/income/verification/paystub/get</c>.</para>
/// </summary>
public partial class IncomeVerificationPaystubGetRequest : RequestBase
{
	/// <summary>
	/// <para>The ID of the verification for which to get paystub information.</para>
	/// </summary>
	[JsonPropertyName("income_verification_id")]
	public string? IncomeVerificationId { get; set; } = default!;
}