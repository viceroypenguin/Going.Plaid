namespace Going.Plaid.Profile;

/// <summary>
/// <para>ProfileNetworkStatusGetResponse defines the response schema for <c>/profile/network_status/get</c></para>
/// </summary>
public record ProfileNetworkStatusGetResponse : ResponseBase
{
	/// <summary>
	/// <para>Enum representing the overall network status of the user</para>
	/// </summary>
	[JsonPropertyName("network_status")]
	public Entity.ProfileNetworkStatusGetNetworkStatus NetworkStatus { get; init; } = default!;

}
