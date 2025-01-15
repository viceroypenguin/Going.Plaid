namespace Going.Plaid.Network;

/// <summary>
/// <para>NetworkStatusGetResponse defines the response schema for <c>/network/status/get</c></para>
/// </summary>
public record NetworkStatusGetResponse : ResponseBase
{
	/// <summary>
	/// <para>Enum representing the overall network status of the user.</para>
	/// </summary>
	[JsonPropertyName("network_status")]
	public Entity.NetworkStatusGetResponseNetworkStatus NetworkStatus { get; init; } = default!;

	/// <summary>
	/// <para>An object representing Layer-related metadata for the requested user.</para>
	/// </summary>
	[JsonPropertyName("layer")]
	public Entity.NetworkStatusGetResponseLayer? Layer { get; init; } = default!;

}
