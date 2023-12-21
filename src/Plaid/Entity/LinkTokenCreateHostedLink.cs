namespace Going.Plaid.Entity;

/// <summary>
/// <para>Configuration parameters for Hosted Link (beta). Only available for participants in the Hosted Link beta program.</para>
/// </summary>
public class LinkTokenCreateHostedLink
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("delivery_method")]
	public Entity.HostedLinkDeliveryMethod? DeliveryMethod { get; set; } = default!;

	/// <summary>
	/// <para>URI that Hosted Link will redirect to upon completion of the Link flow. This will only occur in Hosted Link sessions, not in other implementation methods.</para>
	/// </summary>
	[JsonPropertyName("completion_redirect_uri")]
	public string? CompletionRedirectUri { get; set; } = default!;

	/// <summary>
	/// <para>How many seconds the link will be valid for. Must be positive. Cannot be longer than 21 days. The default lifetime is 4 hours.</para>
	/// </summary>
	[JsonPropertyName("url_lifetime_seconds")]
	public int? UrlLifetimeSeconds { get; set; } = default!;
}