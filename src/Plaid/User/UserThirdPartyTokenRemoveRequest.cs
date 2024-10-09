namespace Going.Plaid.User;

/// <summary>
/// <para>UserThirdPartyTokenCreateRequest defines the request schema for <c>/user/third_party_token/remove</c></para>
/// </summary>
public partial class UserThirdPartyTokenRemoveRequest : RequestBase
{
	/// <summary>
	/// <para>The third-party user token associated with the requested User data.</para>
	/// </summary>
	[JsonPropertyName("third_party_user_token")]
	public string ThirdPartyUserToken { get; set; } = default!;

}
