namespace Going.Plaid.Entity;

/// <summary>
/// <para>Configuration parameters for Hosted Link. To request access to Hosted Link, contact your account manager.</para>
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
	/// <para>How many seconds the link will be valid for. Must be positive. Cannot be longer than 21 days. The default lifetime is 7 days for links delivered by email, 1 day for links delivered via SMS, and 30 minutes for links not sent via Plaid Link delivery. This parameter will override the value of all three link types.</para>
	/// </summary>
	[JsonPropertyName("url_lifetime_seconds")]
	public int? UrlLifetimeSeconds { get; set; } = default!;

	/// <summary>
	/// <para>This indicates whether the client is opening hosted Link in a mobile app in an out of process web view (OOPWV) (i.e., an <c>AsWebAuthenticationSession</c> / <c>SFSafariViewController</c> or Android Custom Tab).</para>
	/// </summary>
	[JsonPropertyName("is_mobile_app")]
	public bool? IsMobileApp { get; set; } = default!;

}
