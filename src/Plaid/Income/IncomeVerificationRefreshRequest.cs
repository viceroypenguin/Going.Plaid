namespace Going.Plaid.Income;

/// <summary>
/// <para>IncomeVerificationRefreshRequest defines the request schema for <c>/income/verification/refresh</c></para>
/// </summary>
public class IncomeVerificationRefreshRequest : RequestBase
{
	/// <summary>
	/// <para>The ID of the verification.</para>
	/// </summary>
	[JsonPropertyName("income_verification_id")]
	public string? IncomeVerificationId { get; set; } = default!;
}