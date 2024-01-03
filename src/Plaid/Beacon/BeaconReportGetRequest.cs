namespace Going.Plaid.Beacon;

/// <summary>
/// <para>Request input for getting a Beacon Report</para>
/// </summary>
public partial class BeaconReportGetRequest : RequestBase
{
	/// <summary>
	/// <para>ID of the associated Beacon Report.</para>
	/// </summary>
	[JsonPropertyName("beacon_report_id")]
	public string BeaconReportId { get; set; } = default!;

}
