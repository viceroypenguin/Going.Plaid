namespace Going.Plaid.Credit;

/// <summary>
/// <para>CreditRelayCreateResponse defines the response schema for <c>/credit/relay/create</c></para>
/// </summary>
public record CreditRelayCreateResponse : ResponseBase
{
	/// <summary>
	/// <para>A token that can be shared with a third party to allow them to access the Asset Report. This token should be stored securely.</para>
	/// </summary>
	[JsonPropertyName("relay_token")]
	public string RelayToken { get; init; } = default!;
}