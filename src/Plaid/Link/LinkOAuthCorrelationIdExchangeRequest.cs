namespace Going.Plaid.Link;

/// <summary>
/// <para>LinkOAuthCorrelationIdExchangeRequest defines the request schema for <c>/link/oauth/correlation_id/exchange</c></para>
/// </summary>
public partial class LinkOAuthCorrelationIdExchangeRequest : RequestBase
{
	/// <summary>
	/// <para>A <c>link_correlation_id</c> from a received OAuth redirect URI callback</para>
	/// </summary>
	[JsonPropertyName("link_correlation_id")]
	public string LinkCorrelationId { get; set; } = default!;

}
