namespace Going.Plaid.LinkDelivery;

/// <summary>
/// <para>LinkDeliveryCreateRequest defines the request schema for <c>/link_delivery/create</c></para>
/// </summary>
public partial class LinkDeliveryCreateRequest : RequestBase
{
	/// <summary>
	/// <para>A <c>link_token</c> from a previous invocation of <c>/link/token/create</c> with Link Delivery enabled</para>
	/// </summary>
	[JsonPropertyName("link_token")]
	public string LinkToken { get; set; } = default!;

	/// <summary>
	/// <para>The delivery method to be used to deliver the Link Delivery URL.</para>
	/// </summary>
	[JsonPropertyName("delivery_method")]
	public Entity.LinkDeliveryDeliveryMethod DeliveryMethod { get; set; } = default!;

	/// <summary>
	/// <para>The email or phone number to be used to delivery the URL of the Link Delivery session</para>
	/// </summary>
	[JsonPropertyName("delivery_destination")]
	public string DeliveryDestination { get; set; } = default!;
}