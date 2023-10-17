namespace Going.Plaid.Entity;

/// <summary>
/// <para>This object includes the scores and risk level. This response is offered as an add-on to /transfer/authorization/create. To request access to these fields please contact your Plaid account manager.</para>
/// </summary>
public record TransferAuthorizationPaymentRisk
{
	/// <summary>
	/// <para>A score from 1-99 that indicates the transaction return risk: a higher risk score suggests a higher return likelihood.</para>
	/// <para>The score evaluates the transaction return risk because an account is overdrawn or because an ineligible account is used and covers return codes: "R01", "R02", "R03", "R04", "R06", "R08",  "R09", "R13",</para>
	/// <para>"R16", "R17", "R20", "R23". These returns have a turnaround time of 2 banking days.</para>
	/// </summary>
	[JsonPropertyName("bank_initiated_return_score")]
	public int? BankInitiatedReturnScore { get; init; } = default!;

	/// <summary>
	/// <para>A score from 1-99 that indicates the transaction return risk: a higher risk score suggests a higher return likelihood.</para>
	/// <para>The score evaluates the transaction return risk of an unauthorized debit and covers return codes: "R05", "R07", "R10", "R11", "R29".</para>
	/// <para>These returns typically have a return time frame of up to 60 calendar days. During this period, the customer of financial institutions can dispute a transaction as unauthorized.</para>
	/// </summary>
	[JsonPropertyName("customer_initiated_return_score")]
	public int? CustomerInitiatedReturnScore { get; init; } = default!;

	/// <summary>
	/// <para>Comprises five risk categories (high risk, medium-high risk, medium risk, medium-low risk, low risk) based on the probability of return</para>
	/// </summary>
	[JsonPropertyName("risk_level")]
	public Entity.TransferAuthorizationRiskLevel? RiskLevel { get; init; } = default!;

	/// <summary>
	/// <para>If bank information was not available to be used in the Signal model, this array contains warnings describing why bank data is missing. If you want to receive an API error instead of Signal scores in the case of missing bank data, file a support ticket or contact your Plaid account manager.</para>
	/// </summary>
	[JsonPropertyName("warnings")]
	public IReadOnlyList<Entity.SignalWarning> Warnings { get; init; } = default!;
}