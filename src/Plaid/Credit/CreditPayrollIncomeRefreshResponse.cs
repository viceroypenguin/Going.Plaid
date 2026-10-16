namespace Going.Plaid.Credit;

/// <summary>
/// <para>CreditPayrollIncomeRefreshResponse defines the response schema for <c>/credit/payroll_income/refresh</c></para>
/// </summary>
public record CreditPayrollIncomeRefreshResponse : ResponseBase
{
	/// <summary>
	/// <para>The verification refresh status. One of the following:</para>
	/// <para><c>"VERIFICATION_REFRESH_SUCCESSFUL"</c> The income verification refresh was successful.</para>
	/// <para><c>"VERIFICATION_REFRESH_NOT_FOUND"</c> No new data was found after the income verification refresh.</para>
	/// </summary>
	[JsonPropertyName("verification_refresh_status")]
	public string VerificationRefreshStatus { get; init; } = default!;

}
