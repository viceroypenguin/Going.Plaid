namespace Going.Plaid.Profile;

/// <summary>
/// <para>ProfileNetworkStatusGetRequest defines the request schema for <c>/profile/network_status/get</c></para>
/// </summary>
public partial class ProfileNetworkStatusGetRequest : RequestBase
{
	/// <summary>
	/// <para>An object specifying information about the end user for the network status check.</para>
	/// </summary>
	[JsonPropertyName("user")]
	public Entity.NetworkStatusGetUser User { get; set; } = default!;

}
