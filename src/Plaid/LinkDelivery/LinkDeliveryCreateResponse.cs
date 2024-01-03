namespace Going.Plaid.LinkDelivery;

/// <summary>
/// <para>LinkDeliveryCreateResponse defines the response schema for <c>/link_delivery/create</c></para>
/// </summary>
public record LinkDeliveryCreateResponse : ResponseBase
{
	/// <summary>
	/// <para>The URL to the Hosted Link session, which will be delivered by the specified delivery method.</para>
	/// </summary>
	[JsonPropertyName("link_delivery_url")]
	public string LinkDeliveryUrl { get; init; } = default!;

	/// <summary>
	/// <para>The ID for the Hosted Link session. Same as the <c>link_token</c> string excluding the "link-{env}-" prefix.</para>
	/// </summary>
	[JsonPropertyName("link_delivery_session_id")]
	public string LinkDeliverySessionId { get; init; } = default!;

}
