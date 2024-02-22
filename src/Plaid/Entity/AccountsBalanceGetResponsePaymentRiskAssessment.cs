namespace Going.Plaid.Entity;

/// <summary>
/// <para>This object provides detailed risk assessment for the requested transaction</para>
/// </summary>
public record AccountsBalanceGetResponsePaymentRiskAssessment
{
	/// <summary>
	/// <para>A five-tier risk assessment for the transaction, based on the probability of ACH returns,</para>
	/// <para>measured by the incident rate.</para>
	/// </summary>
	[JsonPropertyName("risk_level")]
	public string? RiskLevel { get; init; } = default!;

	/// <summary>
	/// <para>Contains additional data that can be used to assess the ACH return risk. Examples of data include:</para>
	/// <para><c>days_since_first_plaid_connection</c>: The number of days since the first time the Item was connected to an application via Plaid</para>
	/// <para><c>plaid_connections_count_7d</c>: The number of times the Item has been connected to applications via Plaid over the past 7 days</para>
	/// <para><c>plaid_connections_count_30d</c>: The number of times the Item has been connected to applications via Plaid over the past 30 days</para>
	/// <para><c>total_plaid_connections_count</c>: The number of times the Item has been connected to applications via Plaid</para>
	/// <para><c>is_savings_or_money_market_account</c>: Indicates whether the ACH transaction funding account is a savings/money market account</para>
	/// <para>For the full list and detailed documentation of attributes available, or to request that attributes not be returned, contact Sales or your Plaid account manager</para>
	/// </summary>
	[JsonPropertyName("attributes")]
	public Entity.BalancePlusAttributes? Attributes { get; init; } = default!;

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
	public DateTimeOffset? BalanceLastUpdated { get; init; } = default!;

	/// <summary>
	/// <para>An array of objects, each representing a specific reason contributing to the risk assessment of an</para>
	/// <para>ACH transaction. This field is particularly useful for understanding risk factors affecting the risk</para>
	/// <para>level assigned to a transaction classified as “high”, “medium-high”, and “medium” risk.</para>
	/// </summary>
	[JsonPropertyName("risk_reasons")]
	public IReadOnlyList<Entity.RiskReason>? RiskReasons { get; init; } = default!;

	/// <summary>
	/// <para>This boolean field denotes if the requested ACH debit amount exceeds the calculated threshold based on either the available or current balance</para>
	/// <para>of the bank account. Specifically, it checks if the amount is greater than the account balance multiplied by "balance_threshold_percentage"/100.</para>
	/// <para>In cases where available_balance is not accessible, current_balance is used. This field is particularly useful for clients handling indirect items</para>
	/// <para>who lack direct access to raw balance data.</para>
	/// </summary>
	[JsonPropertyName("exceeds_balance_threshold")]
	public bool? ExceedsBalanceThreshold { get; init; } = default!;

}
