namespace Going.Plaid.Entity;

/// <summary>
/// <para>Risk scoring details broken down by risk category. When using a Balance-only ruleset, this object will not be returned.</para>
/// </summary>
public record SignalEvaluateScores
{
	/// <summary>
	/// <para>The object contains a risk score and a risk tier that evaluate the transaction return risk of an unauthorized debit. Common return codes in this category include: "R05", "R07", "R10", "R11", "R29". These returns typically have a return time frame of up to 60 calendar days. During this period, the customer of financial institutions can dispute a transaction as unauthorized.</para>
	/// </summary>
	[JsonPropertyName("customer_initiated_return_risk")]
	public Entity.CustomerInitiatedReturnRisk? CustomerInitiatedReturnRisk { get; init; } = default!;

	/// <summary>
	/// <para>The object contains a risk score and a risk tier that evaluate the transaction return risk because an account is overdrawn or because an ineligible account is used. Common return codes in this category include: "R01", "R02", "R03", "R04", "R06", "R08", "R09", "R13", "R16", "R17", "R20", "R23". These returns have a turnaround time of 2 banking days.</para>
	/// </summary>
	[JsonPropertyName("bank_initiated_return_risk")]
	public Entity.BankInitiatedReturnRisk? BankInitiatedReturnRisk { get; init; } = default!;

}
