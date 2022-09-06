namespace Going.Plaid.Entity;

/// <summary>
/// <para>The object contains a risk score and a risk tier that evaluate the transaction return risk of an unauthorized debit. Common return codes in this category include: "R05", "R07", "R10", "R11", "R29". These returns typically have a return time frame of up to 60 calendar days. During this period, the customer of financial institutions can dispute a transaction as unauthorized.</para>
/// </summary>
public record CustomerInitiatedReturnRisk
{
	/// <summary>
	/// <para>A score from 1-99 that indicates the transaction return risk: a higher risk score suggests a higher return likelihood.</para>
	/// </summary>
	[JsonPropertyName("score")]
	public int Score { get; init; } = default!;

	/// <summary>
	/// <para>A tier corresponding to the projected likelihood that the transaction, if initiated, will be subject to a return.</para>
	/// <para>In the <c>customer_initiated_return_risk</c> object, there are five risk tiers corresponding to the scores:</para>
	/// <para>  1: Predicted customer-initiated return incidence rate between 0.00% - 0.02%</para>
	/// <para>  2: Predicted customer-initiated return incidence rate between 0.02% - 0.05%</para>
	/// <para>  3: Predicted customer-initiated return incidence rate between 0.05% - 0.1%</para>
	/// <para>  4: Predicted customer-initiated return incidence rate between 0.1% - 0.5%</para>
	/// <para>  5: Predicted customer-initiated return incidence rate greater than 0.5%</para>
	/// </summary>
	[JsonPropertyName("risk_tier")]
	public int RiskTier { get; init; } = default!;
}