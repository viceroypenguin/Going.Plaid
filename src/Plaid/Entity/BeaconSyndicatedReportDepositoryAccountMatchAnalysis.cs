namespace Going.Plaid.Entity;

/// <summary>
/// <para>Analysis of whether this account matched between the originally reported Beacon User and the Beacon User that the report syndicated to.</para>
/// </summary>
public record BeaconSyndicatedReportDepositoryAccountMatchAnalysis
{
	/// <summary>
	/// <para>The last 2-4 numeric characters of this account’s account number.</para>
	/// </summary>
	[JsonPropertyName("account_mask")]
	public string AccountMask { get; init; } = default!;

	/// <summary>
	/// <para>The routing number of the account.</para>
	/// </summary>
	[JsonPropertyName("routing_number")]
	public string RoutingNumber { get; init; } = default!;

	/// <summary>
	/// <para>An enum indicating the match type between two Beacon Users.</para>
	/// </summary>
	[JsonPropertyName("match_status")]
	public Entity.BeaconMatchSummaryCode MatchStatus { get; init; } = default!;

}
