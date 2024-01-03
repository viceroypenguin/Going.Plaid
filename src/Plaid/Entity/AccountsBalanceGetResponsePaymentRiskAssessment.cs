namespace Going.Plaid.Entity;

/// <summary>
/// <para>This object provides detailed risk assessment for the requested transaction</para>
/// </summary>
public record AccountsBalanceGetResponsePaymentRiskAssessment
{
	/// <summary>
	/// <para>A five-tier risk assessment for the transaction based on the probability of return.</para>
	/// </summary>
	[JsonPropertyName("risk_level")]
	public string? RiskLevel { get; init; } = default!;

	/// <summary>
	/// <para>Indicates whether the requested ACH debit amount is greater than the threshold (set by customers) of the available or current balance.</para>
	/// </summary>
	[JsonPropertyName("exceeds_balance_threshold")]
	public bool? ExceedsBalanceThreshold { get; init; } = default!;

}
