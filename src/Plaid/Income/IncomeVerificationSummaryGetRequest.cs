namespace Going.Plaid.Income;

/// <summary>
/// <para>IncomeVerificationSummaryGetRequest defines the request schema for <c>/income/verification/summary/get</c>.</para>
/// </summary>
public class IncomeVerificationSummaryGetRequest : RequestBase
{
	/// <summary>
	/// <para>The ID of the verification.</para>
	/// </summary>
	[JsonPropertyName("income_verification_id")]
	public string? IncomeVerificationId { get; set; } = default!;
}