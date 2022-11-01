namespace Going.Plaid.Link;

/// <summary>
/// <para>LinkOAuthCorrelationIdExchangeResponse defines the response schema for <c>/link/oauth/correlation_id/exchange</c></para>
/// </summary>
public record LinkOAuthCorrelationIdExchangeResponse : ResponseBase
{
	/// <summary>
	/// <para>The <c>link_token</c> associated to the given <c>link_correlation_id</c>, which can be used to re-initialize Link.</para>
	/// </summary>
	[JsonPropertyName("link_token")]
	public string LinkToken { get; init; } = default!;
}