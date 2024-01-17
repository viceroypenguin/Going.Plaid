namespace Going.Plaid.Beacon;

/// <summary>
/// <para>A Beacon Duplicate represents a pair of matching Beacon Users and an analysis of the fields they matched on.</para>
/// </summary>
public record BeaconDuplicateGetResponse : ResponseBase
{
	/// <summary>
	/// <para>ID of the associated Beacon Duplicate.</para>
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; init; } = default!;

	/// <summary>
	/// <para>A Beacon User Revision identifies a Beacon User at some point in its revision history.</para>
	/// </summary>
	[JsonPropertyName("beacon_user1")]
	public Entity.BeaconUserRevision BeaconUser1 { get; init; } = default!;

	/// <summary>
	/// <para>A Beacon User Revision identifies a Beacon User at some point in its revision history.</para>
	/// </summary>
	[JsonPropertyName("beacon_user2")]
	public Entity.BeaconUserRevision BeaconUser2 { get; init; } = default!;

	/// <summary>
	/// <para>Analysis of which fields matched between one Beacon User and another.</para>
	/// </summary>
	[JsonPropertyName("analysis")]
	public Entity.BeaconMatchSummaryAnalysis Analysis { get; init; } = default!;

}
