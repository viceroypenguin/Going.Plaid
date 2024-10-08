namespace Going.Plaid.User;

/// <summary>
/// <para>UserThirdPartyTokenCreateRequest defines the request schema for <c>/user/third_party_token/create</c></para>
/// </summary>
public partial class UserThirdPartyTokenCreateRequest : RequestBase
{
	/// <summary>
	/// <para>The user token associated with the User data is being requested for.</para>
	/// </summary>
	[JsonPropertyName("user_token")]
	public string UserToken { get; set; } = default!;

	/// <summary>
	/// <para>The Plaid API <c>client_id</c> of the third-party client the token will be shared with. The token will only be valid for the specified client.</para>
	/// </summary>
	[JsonPropertyName("third_party_client_id")]
	public string ThirdPartyClientId { get; set; } = default!;

	/// <summary>
	/// <para>The expiration date and time for the third-party user token in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format (<c>YYYY-MM-DDThh:mm:ssZ</c>). The expiration is restricted to a maximum of 24 hours from the token's creation time. If not provided, the token will automatically expire after 24 hours.</para>
	/// </summary>
	[JsonPropertyName("expiration_time")]
	public DateTimeOffset? ExpirationTime { get; set; } = default!;

}
