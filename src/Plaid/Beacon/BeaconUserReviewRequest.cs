namespace Going.Plaid.Beacon;

/// <summary>
/// <para>Request input for updating the status of a Beacon User</para>
/// </summary>
public partial class BeaconUserReviewRequest : RequestBase
{
	/// <summary>
	/// <para>ID of the associated Beacon User.</para>
	/// </summary>
	[JsonPropertyName("beacon_user_id")]
	public string BeaconUserId { get; set; } = default!;

	/// <summary>
	/// <para>A status of a Beacon User.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.BeaconUserStatus Status { get; set; } = default!;

}
