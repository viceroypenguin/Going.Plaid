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
	/// <para>The expiration date for the <c>link_token</c>, in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format. A <c>link_token</c> created to generate a <c>public_token</c> that will be exchanged for a new <c>access_token</c> expires after 4 hours. A <c>link_token</c> created for an existing Item (such as when updating an existing <c>access_token</c> by launching Link in update mode) expires after 30 minutes.</para>
	/// </summary>
	[JsonPropertyName("expiration")]
	public DateTimeOffset Expiration { get; init; } = default!;

	/// <summary>
	/// <para>A URL of a Plaid-hosted Link flow that will use the Link token returned by this request</para>
	/// </summary>
	[JsonPropertyName("hosted_link_url")]
	public string? HostedLinkUrl { get; init; } = default!;
}