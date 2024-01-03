namespace Going.Plaid.Entity;

/// <summary>
/// <para>Analysis of which fields matched between the originally reported Beacon User and the Beacon User that the report was syndicated to.</para>
/// </summary>
public record BeaconReportSyndicationAnalysis
{
	/// <summary>
	/// <para>An enum indicating the match type between two Beacon Users.</para>
	/// </summary>
	[JsonPropertyName("address")]
	public Entity.BeaconMatchSummaryCode Address { get; init; } = default!;

	/// <summary>
	/// <para>An enum indicating the match type between two Beacon Users.</para>
	/// </summary>
	[JsonPropertyName("date_of_birth")]
	public Entity.BeaconMatchSummaryCode DateOfBirth { get; init; } = default!;

	/// <summary>
	/// <para>An enum indicating the match type between two Beacon Users.</para>
	/// </summary>
	[JsonPropertyName("email_address")]
	public Entity.BeaconMatchSummaryCode EmailAddress { get; init; } = default!;

	/// <summary>
	/// <para>An enum indicating the match type between two Beacon Users.</para>
	/// </summary>
	[JsonPropertyName("name")]
	public Entity.BeaconMatchSummaryCode Name { get; init; } = default!;

	/// <summary>
	/// <para>An enum indicating the match type between two Beacon Users.</para>
	/// </summary>
	[JsonPropertyName("id_number")]
	public Entity.BeaconMatchSummaryCode IdNumber { get; init; } = default!;

	/// <summary>
	/// <para>An enum indicating the match type between two Beacon Users.</para>
	/// </summary>
	[JsonPropertyName("ip_address")]
	public Entity.BeaconMatchSummaryCode IpAddress { get; init; } = default!;

	/// <summary>
	/// <para>An enum indicating the match type between two Beacon Users.</para>
	/// </summary>
	[JsonPropertyName("phone_number")]
	public Entity.BeaconMatchSummaryCode PhoneNumber { get; init; } = default!;

}
