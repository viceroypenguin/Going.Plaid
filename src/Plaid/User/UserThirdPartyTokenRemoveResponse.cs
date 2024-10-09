namespace Going.Plaid.User;

/// <summary>
/// <para>UserThirdPartyTokenCreateResponse defines the response schema for <c>/user/third_party_token/remove</c></para>
/// </summary>
public record UserThirdPartyTokenRemoveResponse : ResponseBase
{
	/// <summary>
	/// <para><c>true</c> if the third-party user token was successfully removed.</para>
	/// </summary>
	[JsonPropertyName("removed")]
	public bool Removed { get; init; } = default!;

}
