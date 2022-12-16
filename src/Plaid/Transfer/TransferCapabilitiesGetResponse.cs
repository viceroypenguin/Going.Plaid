namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the response schema for <c>/transfer/capabilities/get</c></para>
/// </summary>
public record TransferCapabilitiesGetResponse : ResponseBase
{
	/// <summary>
	/// <para>Contains the supported RTP network and types by the linked item's institution</para>
	/// </summary>
	[JsonPropertyName("institution_supported_networks")]
	public Entity.InstitutionSupportedNetworks InstitutionSupportedNetworks { get; init; } = default!;
}