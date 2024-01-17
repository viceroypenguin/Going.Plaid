namespace Going.Plaid.Beacon;

/// <summary>
/// <para>Request input for getting a Beacon Duplicate</para>
/// </summary>
public partial class BeaconDuplicateGetRequest : RequestBase
{
	/// <summary>
	/// <para>ID of the associated Beacon Duplicate.</para>
	/// </summary>
	[JsonPropertyName("beacon_duplicate_id")]
	public string BeaconDuplicateId { get; set; } = default!;

}
