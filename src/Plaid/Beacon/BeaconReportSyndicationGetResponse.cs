namespace Going.Plaid.Beacon;

/// <summary>
/// <para>A Beacon Report Syndication represents a Beacon Report created either by your organization or another Beacon customer that matches a specific Beacon User you've created.</para>
/// <para>The <c>analysis</c> field in the response indicates which fields matched between the originally reported Beacon User and the Beacon User that the report was syndicated to.</para>
/// <para>The <c>report</c> field in the response contains a subset of information from the original report.</para>
/// </summary>
public record BeaconReportSyndicationGetResponse : ResponseBase
{
	/// <summary>
	/// <para>ID of the associated Beacon Report Syndication.</para>
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; init; } = default!;

	/// <summary>
	/// <para>A subset of information from a Beacon Report that has been syndicated to a matching Beacon User in your program.</para>
	/// <para>The <c>id</c> field in the response is the ID of the original report that was syndicated. If the original report was created by your organization, the field will be filled with the ID of the report. Otherwise, the field will be <c>null</c> indicating that the original report was created by another Beacon customer.</para>
	/// </summary>
	[JsonPropertyName("report")]
	public Entity.BeaconReportSyndicationOriginalReport Report { get; init; } = default!;

	/// <summary>
	/// <para>Analysis of which fields matched between the originally reported Beacon User and the Beacon User that the report was syndicated to.</para>
	/// </summary>
	[JsonPropertyName("analysis")]
	public Entity.BeaconReportSyndicationAnalysis Analysis { get; init; } = default!;
}