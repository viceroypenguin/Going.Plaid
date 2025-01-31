namespace Going.Plaid.Entity;

/// <summary>
/// <para>Contains the RTP and RfP network and types supported by the linked Item's institution.</para>
/// </summary>
public record InstitutionSupportedNetworks
{
	/// <summary>
	/// <para>Contains the supported service types in RTP</para>
	/// </summary>
	[JsonPropertyName("rtp")]
	public Entity.TransferCapabilitiesGetRTP Rtp { get; init; } = default!;

	/// <summary>
	/// <para>Contains the supported service types in RfP</para>
	/// </summary>
	[JsonPropertyName("rfp")]
	public Entity.TransferCapabilitiesGetRfP Rfp { get; init; } = default!;

}
