namespace Going.Plaid.Entity;

/// <summary>
/// <para>Provides a detailed risk assessment for the requested transaction. For this field to be returned, the client must be enrolled in the Balance Plus beta program and the <a href="http://plaid.com/docs/balance/balance-plus/#accounts-balance-get-request-payment-details"><c>payment_details</c></a> object must have been sent in the request.</para>
/// </summary>
public record AccountsBalanceGetResponsePaymentRiskAssessment
{
	/// <summary>
	/// <para>A five-tier risk assessment for the transaction, based on the probability distribution of ACH returns,</para>
	/// </summary>
	[JsonPropertyName("risk_level")]
	public Entity.BalancePlusRiskLevel RiskLevel { get; init; } = default!;

	/// <summary>
	/// <para>Contains additional data that can be used to assess the ACH return risk</para>
	/// </summary>
	[JsonPropertyName("attributes")]
	public Entity.BalancePlusAttributes Attributes { get; init; } = default!;

	/// <summary>
	/// <para>A risk score ranging from 1-99, reflecting the likelihood of ACH debit return.</para>
	/// <para>A higher score indicates a greater risk of return, often due to overdrawn accounts or account</para>
	/// <para>ineligibility to receive ACH transactions. Typical return codes include "R01", "R02", "R03",</para>
	/// <para>"R04", "R06", "R08", "R09", "R13", "R16", "R17", "R20", "R23", etc., with a turnaround of 2 banking days.</para>
	/// </summary>
	[JsonPropertyName("score")]
	public int? Score { get; init; } = default!;

	/// <summary>
	/// <para>Timestamp of the last successful balance update, in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format.</para>
	/// </summary>
	[JsonPropertyName("balance_last_updated")]
	public DateTimeOffset BalanceLastUpdated { get; init; } = default!;

	/// <summary>
	/// <para>An array of objects, each representing a specific reason contributing to the risk assessment of an ACH transaction. This field is only supplied for transactions classified as <c>HIGH</c>, <c>MEDIUM-HIGH</c>, or <c>MEDIUM</c> risk.</para>
	/// </summary>
	[JsonPropertyName("risk_reasons")]
	public IReadOnlyList<Entity.RiskReason>? RiskReasons { get; init; } = default!;

	/// <summary>
	/// <para>Whether the proposed transaction exceeds the balance threshold set in the request. <c>true</c> indicates higher risk; <c>false</c> indicates lower risk. If the <c>amount</c> multiplied by the <c>balance_threshold_percentage</c> (as a percentage) exceeds the balance in the account, then <c>exceeds_balance_threshold</c> will be true, otherwise, it will be false. For example, if the <c>amount</c> is 200 and the <c>balance_threshold_percentage</c> is 90, then the account balance must be at least 180 for <c>exceeds_balance_threshold</c> to be false. </para>
	/// <para>By default, the available balance will be used for this calculation; if it cannot be obtained, the current balance will be used. </para>
	/// <para>This field is particularly useful for customers using indirect Items and who do not have direct access to raw balance data.</para>
	/// </summary>
	[JsonPropertyName("exceeds_balance_threshold")]
	public bool ExceedsBalanceThreshold { get; init; } = default!;

}
