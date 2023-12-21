namespace Going.Plaid.Beacon;

/// <summary>
/// <para>Request input for getting a Beacon Report Syndication</para>
/// </summary>
public partial class BeaconReportSyndicationGetRequest : RequestBase
{
	/// <summary>
	/// <para>ID of the associated Beacon Report Syndication.</para>
	/// </summary>
	[JsonPropertyName("beacon_report_syndication_id")]
	public string BeaconReportSyndicationId { get; set; } = default!;
}