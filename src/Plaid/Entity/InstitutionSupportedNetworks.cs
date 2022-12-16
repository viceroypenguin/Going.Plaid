namespace Going.Plaid.Entity;

/// <summary>
/// <para>Contains the supported RTP network and types by the linked item's institution</para>
/// </summary>
public record InstitutionSupportedNetworks
{
	/// <summary>
	/// <para>Contains the supported service types in RTP</para>
	/// </summary>
	[JsonPropertyName("rtp")]
	public Entity.TransferCapabilitiesGetRTP Rtp { get; init; } = default!;
}