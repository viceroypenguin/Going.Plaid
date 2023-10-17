namespace Going.Plaid.Beacon;

/// <summary>
/// <para>The response schema for <c>/beacon/report/list</c></para>
/// </summary>
public record BeaconReportListResponse : ResponseBase
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("beacon_reports")]
	public IReadOnlyList<Entity.BeaconReport> BeaconReports { get; init; } = default!;

	/// <summary>
	/// <para>An identifier that determines which page of results you receive.</para>
	/// </summary>
	[JsonPropertyName("next_cursor")]
	public string? NextCursor { get; init; } = default!;
}