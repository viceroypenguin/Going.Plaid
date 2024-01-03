namespace Going.Plaid.Beacon;

/// <summary>
/// <para>Request input for updating the identity data of a Beacon User.</para>
/// </summary>
public partial class BeaconUserUpdateRequest : RequestBase
{
	/// <summary>
	/// <para>ID of the associated Beacon User.</para>
	/// </summary>
	[JsonPropertyName("beacon_user_id")]
	public string BeaconUserId { get; set; } = default!;

	/// <summary>
	/// <para>A subset of a Beacon User's data which is used to patch the existing identity data associated with a Beacon User. At least one field must be provided,.</para>
	/// </summary>
	[JsonPropertyName("user")]
	public Entity.BeaconUserUpdateRequestData User { get; set; } = default!;

}
