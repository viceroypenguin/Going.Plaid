namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object representing the loan exposure subcategory of the report</para>
/// </summary>
public record MonitoringLoanInsights
{
	/// <summary>
	/// <para>An object representing the insights in the number of loan payments</para>
	/// </summary>
	[JsonPropertyName("loan_payments_counts")]
	public Entity.LoanPaymentsCounts LoanPaymentsCounts { get; init; } = default!;

	/// <summary>
	/// <para>The number of loan disbursements detected in the last 30 days</para>
	/// </summary>
	[JsonPropertyName("loan_disbursements_count")]
	public decimal LoanDisbursementsCount { get; init; } = default!;

	/// <summary>
	/// <para>An object representing the insights in the number of unique loan payment merchants</para>
	/// </summary>
	[JsonPropertyName("loan_payment_merchants_counts")]
	public Entity.LoanPaymentsMerchantCounts LoanPaymentMerchantsCounts { get; init; } = default!;

}
