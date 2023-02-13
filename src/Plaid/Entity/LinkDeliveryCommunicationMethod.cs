namespace Going.Plaid.Entity;

/// <summary>
/// <para>The communication method containing both the type and address to send the URL.</para>
/// </summary>
public class LinkDeliveryCommunicationMethod
{
	/// <summary>
	/// <para>The delivery method to be used to deliver the Link Delivery URL.</para>
	/// </summary>
	[JsonPropertyName("method")]
	public Entity.LinkDeliveryDeliveryMethod Method { get; set; } = default!;

	/// <summary>
	/// <para>The address to deliver the Link Delivery URL</para>
	/// </summary>
	[JsonPropertyName("address")]
	public string Address { get; set; } = default!;
}