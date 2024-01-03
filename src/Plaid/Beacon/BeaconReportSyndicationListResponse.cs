namespace Going.Plaid.Beacon;

/// <summary>
/// <para>The response schema for <c>/beacon/report_syndication/list</c></para>
/// </summary>
public record BeaconReportSyndicationListResponse : ResponseBase
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("beacon_report_syndications")]
	public IReadOnlyList<Entity.BeaconReportSyndication> BeaconReportSyndications { get; init; } = default!;

	/// <summary>
	/// <para>An identifier that determines which page of results you receive.</para>
	/// </summary>
	[JsonPropertyName("next_cursor")]
	public string? NextCursor { get; init; } = default!;

}
