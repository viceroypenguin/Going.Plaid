namespace Going.Plaid.Entity;

/// <summary>
/// <para>Insights from performing database verification for the account. Only returned for Auth Items created via Database Insights.</para>
/// </summary>
public record VerificationInsights
{
	/// <summary>
	/// <para>Status information about the account and routing number in the Plaid network.</para>
	/// </summary>
	[JsonPropertyName("network_status")]
	public Entity.VerificationInsightsNetworkStatus NetworkStatus { get; init; } = default!;

	/// <summary>
	/// <para>Information about known ACH returns for the account and routing number.</para>
	/// </summary>
	[JsonPropertyName("previous_returns")]
	public Entity.VerificationInsightsNetworkStatus? PreviousReturns { get; init; } = default!;

	/// <summary>
	/// <para>Indicator of account number format validity for institution.</para>
	/// </summary>
	[JsonPropertyName("account_number_format")]
	public Entity.VerificationInsightsAccountNumberFormat AccountNumberFormat { get; init; } = default!;

}
