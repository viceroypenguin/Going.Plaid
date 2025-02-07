namespace Going.Plaid.Link;

/// <summary>
/// <para>LinkTokenCreateResponse defines the response schema for <c>/link/token/create</c></para>
/// </summary>
public record LinkTokenCreateResponse : ResponseBase
{
	/// <summary>
	/// <para>A <c>link_token</c>, which can be supplied to Link in order to initialize it and receive a <c>public_token</c>, which can be exchanged for an <c>access_token</c>.</para>
	/// </summary>
	[JsonPropertyName("link_token")]
	public string LinkToken { get; init; } = default!;

	/// <summary>
	/// <para>The expiration date and time for the <c>link_token</c>, in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format. By default, a <c>link_token</c> created to generate a <c>public_token</c> that will be exchanged for a new <c>access_token</c> expires after 4 hours, and a <c>link_token</c> created for an existing Item (such as when updating an existing <c>access_token</c> by launching Link in update mode) expires after 30 minutes. If using <a href="https://plaid.com/docs/link/hosted-link/">Hosted Link</a>, the <c>link_token</c> will expire at the same time as the Hosted Link URL, and you can customize the duration using the <c>hosted_link.url_lifetime_seconds</c> option in the request. If using Link Delivery (beta), the <c>link_token</c> will expire by default after 24 hours if sent via SMS and after 7 days if sent via email. If using Identity Verification, Link token expiration will not be enforced; an Identity Verification Link session can be created with an expired Link token.</para>
	/// </summary>
	[JsonPropertyName("expiration")]
	public DateTimeOffset Expiration { get; init; } = default!;

	/// <summary>
	/// <para>A URL of a Plaid-hosted Link flow that will use the Link token returned by this request. Only present if the session is enabled for Hosted Link. To enable the session for Hosted Link, send a <c>hosted_link</c> object in the request.</para>
	/// </summary>
	[JsonPropertyName("hosted_link_url")]
	public string? HostedLinkUrl { get; init; } = default!;

}
