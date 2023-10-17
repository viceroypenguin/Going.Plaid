namespace Going.Plaid.Entity;

/// <summary>
/// <para>Configuration parameters for Hosted Link</para>
/// </summary>
public class LinkTokenCreateHostedLink
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("delivery_method")]
	public Entity.HostedLinkDeliveryMethod? DeliveryMethod { get; set; } = default!;

	/// <summary>
	/// <para>URI that Hosted Link will redirect to upon completion of the Link flow. This will only occur in Hosted Link</para>
	/// <para>sessions, not in other implementation methods.</para>
	/// </summary>
	[JsonPropertyName("completion_redirect_uri")]
	public string? CompletionRedirectUri { get; set; } = default!;
}