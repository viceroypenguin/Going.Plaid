namespace Going.Plaid.LinkDelivery;

/// <summary>
/// <para>LinkDeliveryCreateRequest defines the request schema for <c>/link_delivery/create</c></para>
/// </summary>
public partial class LinkDeliveryCreateRequest : RequestBase
{
	/// <summary>
	/// <para>A <c>link_token</c> from a previous invocation of <c>/link/token/create</c>.</para>
	/// </summary>
	[JsonPropertyName("link_token")]
	public string LinkToken { get; set; } = default!;

	/// <summary>
	/// <para>Optional metadata related to the Hosted Link session</para>
	/// </summary>
	[JsonPropertyName("options")]
	public Entity.LinkDeliveryOptions? Options { get; set; } = default!;
}