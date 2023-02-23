namespace Going.Plaid.LinkDelivery;

/// <summary>
/// <para>LinkDeliveryCreateRequest defines the request schema for <c>/link_delivery/create</c></para>
/// </summary>
public partial class LinkDeliveryCreateRequest : RequestBase
{
	/// <summary>
	/// <para>A <c>link_token</c> from a previous invocation of <c>/link/token/create</c> with Link Delivery enabled.</para>
	/// </summary>
	[JsonPropertyName("link_token")]
	public string LinkToken { get; set; } = default!;

	/// <summary>
	/// <para>The list of communication methods to send the Link Delivery URL to.</para>
	/// </summary>
	[JsonPropertyName("communication_methods")]
	public IReadOnlyList<Entity.LinkDeliveryCommunicationMethod> CommunicationMethods { get; set; } = default!;
}