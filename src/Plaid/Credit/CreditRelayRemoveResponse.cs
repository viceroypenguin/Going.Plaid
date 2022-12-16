namespace Going.Plaid.Credit;

/// <summary>
/// <para>CreditRelayRemoveResponse defines the response schema for <c>/credit/relay/remove</c></para>
/// </summary>
public record CreditRelayRemoveResponse : ResponseBase
{
	/// <summary>
	/// <para><c>true</c> if the relay token was successfully removed.</para>
	/// </summary>
	[JsonPropertyName("removed")]
	public bool Removed { get; init; } = default!;
}