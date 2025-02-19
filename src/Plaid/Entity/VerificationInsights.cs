namespace Going.Plaid.Entity;

/// <summary>
/// <para>Insights from performing database verification for the account. Only returned for Auth Items created via Database Insights.</para>
/// </summary>
public record VerificationInsights
{
	/// <summary>
	/// <para>Indicates the score of the name match between the given name provided during database verification and matched Plaid network accounts. If defined, will be a value between 0 and 100. Will be undefined if name matching was not enabled for the database verification session or if there were no eligible Plaid network matches to compare the given name with.</para>
	/// </summary>
	[JsonPropertyName("name_match_score")]
	public int? NameMatchScore { get; init; } = default!;

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
