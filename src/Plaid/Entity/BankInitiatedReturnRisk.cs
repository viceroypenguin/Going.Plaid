namespace Going.Plaid.Entity;

/// <summary>
/// <para>The object contains a risk score and a risk tier that evaluate the transaction return risk because an account is overdrawn or because an ineligible account is used. Common return codes in this category include: "R01", "R02", "R03", "R04", "R06", "R08",  "R09", "R13", "R16", "R17", "R20", "R23". These returns have a turnaround time of 2 banking days.</para>
/// </summary>
public record BankInitiatedReturnRisk
{
	/// <summary>
	/// <para>A score from 1-99 that indicates the transaction return risk: a higher risk score suggests a higher return likelihood.</para>
	/// </summary>
	[JsonPropertyName("score")]
	public int Score { get; init; } = default!;

	/// <summary>
	/// <para>DEPRECATED. Use Signal Rules instead to transform the <c>score</c> into a useful action.  </para>
	/// <para>In the <c>bank_initiated_return_risk</c> object, there are eight risk tiers corresponding to the scores:</para>
	/// <para>  1: Predicted bank-initiated return incidence rate between 0.0% - 0.5%</para>
	/// <para>  2: Predicted bank-initiated return incidence rate between 0.5% - 1.5%</para>
	/// <para>  3: Predicted bank-initiated return incidence rate between 1.5% - 3%</para>
	/// <para>  4: Predicted bank-initiated return incidence rate between 3% - 5%</para>
	/// <para>  5: Predicted bank-initiated return incidence rate between 5% - 10%</para>
	/// <para>  6: Predicted bank-initiated return incidence rate between 10% - 15%</para>
	/// <para>  7: Predicted bank-initiated return incidence rate between 15% and 50%</para>
	/// <para>  8: Predicted bank-initiated return incidence rate greater than 50%</para>
	/// </summary>
	[JsonPropertyName("risk_tier")]
	public int RiskTier { get; init; } = default!;

}
