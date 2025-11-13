namespace Going.Plaid.Entity;

/// <summary>
/// <para>Risk indicators focus on providing signal on the possibility of a borrower defaulting on their loan repayments by providing data points related to its payment behavior, debt, and other relevant financial information, helping lenders gauge the level of risk involved in a certain operation.</para>
/// </summary>
public record RiskIndicators
{
	/// <summary>
	/// <para>Insights into bank penalties and fees, including overdraft fees, NSF fees, and other bank-imposed charges.</para>
	/// </summary>
	[JsonPropertyName("bank_penalties")]
	public Entity.BankPenaltiesIndicators? BankPenalties { get; init; } = default!;

	/// <summary>
	/// <para>Insights into gambling-related transactions, including frequency, amounts, and top merchants.</para>
	/// </summary>
	[JsonPropertyName("gambling")]
	public Entity.GamblingIndicators? Gambling { get; init; } = default!;

	/// <summary>
	/// <para>Insights into loan disbursement transactions received by the user, tracking incoming funds from loan providers.</para>
	/// </summary>
	[JsonPropertyName("loan_disbursements")]
	public Entity.LoanDisbursementsIndicators? LoanDisbursements { get; init; } = default!;

	/// <summary>
	/// <para>Insights into loan payment transactions made by the user, tracking outgoing payments to loan providers.</para>
	/// </summary>
	[JsonPropertyName("loan_payments")]
	public Entity.LoanPaymentsIndicators? LoanPayments { get; init; } = default!;

	/// <summary>
	/// <para>Insights into negative balance occurrences, including frequency, duration, and minimum balance details.</para>
	/// </summary>
	[JsonPropertyName("negative_balance")]
	public Entity.NegativeBalanceInsights? NegativeBalance { get; init; } = default!;

}
