namespace Going.Plaid.LinkDelivery;

/// <summary>
/// <para>LinkDeliveryGetRequest defines the request schema for <c>/link_delivery/get</c></para>
/// </summary>
public partial class LinkDeliveryGetRequest : RequestBase
{
	/// <summary>
	/// <para>The ID for the Hosted Link session from a previous invocation of <c>/link_delivery/create</c>.</para>
	/// </summary>
	[JsonPropertyName("link_delivery_session_id")]
	public string LinkDeliverySessionId { get; set; } = default!;

}
