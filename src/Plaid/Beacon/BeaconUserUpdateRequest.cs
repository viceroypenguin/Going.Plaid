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
	/// <para>A subset of a Beacon User's data which is used to patch the existing identity data associated with a Beacon User. At least one field must be provided. If left unset or null, user data will not be patched.</para>
	/// </summary>
	[JsonPropertyName("user")]
	public Entity.BeaconUserUpdateRequestData? User { get; set; } = default!;

	/// <summary>
	/// <para>Send this array of access tokens to add accounts to this user for evaluation.</para>
	/// <para>This will add accounts to this Beacon User. If left null only existing accounts will be returned in response.</para>
	/// <para>A maximum of 50 accounts total can be added to a Beacon User.</para>
	/// </summary>
	[JsonPropertyName("access_tokens")]
	public IReadOnlyList<string>? AccessTokens { get; set; } = default!;

}
