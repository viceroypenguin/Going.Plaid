namespace Going.Plaid.Beacon;

/// <summary>
/// <para>Request input for fetching a Beacon User</para>
/// </summary>
public partial class BeaconUserGetRequest : RequestBase
{
	/// <summary>
	/// <para>ID of the associated Beacon User.</para>
	/// </summary>
	[JsonPropertyName("beacon_user_id")]
	public string BeaconUserId { get; set; } = default!;
}