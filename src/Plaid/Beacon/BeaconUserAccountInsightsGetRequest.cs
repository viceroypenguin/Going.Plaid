namespace Going.Plaid.Beacon;

/// <summary>
/// <para>Request input for fetching the risk insights for a Beacon User's Bank Accounts</para>
/// </summary>
public partial class BeaconUserAccountInsightsGetRequest : RequestBase
{
	/// <summary>
	/// <para>ID of the associated Beacon User.</para>
	/// </summary>
	[JsonPropertyName("beacon_user_id")]
	public string BeaconUserId { get; set; } = default!;

}
