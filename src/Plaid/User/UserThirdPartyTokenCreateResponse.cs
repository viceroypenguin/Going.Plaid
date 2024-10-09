namespace Going.Plaid.User;

/// <summary>
/// <para>UserThirdPartyTokenCreateResponse defines the response schema for <c>/user/third_party_token/create</c></para>
/// </summary>
public record UserThirdPartyTokenCreateResponse : ResponseBase
{
	/// <summary>
	/// <para>The third-party user token associated with the requested User data.</para>
	/// </summary>
	[JsonPropertyName("third_party_user_token")]
	public string ThirdPartyUserToken { get; init; } = default!;

}
