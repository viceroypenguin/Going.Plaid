namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the response schema for <c>/transfer/capabilities/get</c></para>
/// </summary>
public record TransferCapabilitiesGetResponse : ResponseBase
{
	/// <summary>
	/// <para>Contains the RTP and RfP network and types supported by the linked Item's institution.</para>
	/// </summary>
	[JsonPropertyName("institution_supported_networks")]
	public Entity.InstitutionSupportedNetworks InstitutionSupportedNetworks { get; init; } = default!;

}
