namespace Going.Plaid.User;

/// <summary>
/// <para>UserRemoveRequest defines the request schema for <c>/user/remove</c></para>
/// </summary>
public partial class UserRemoveRequest : RequestBase
{
	/// <summary>
	/// <para>The user token associated with the User data is being requested for.</para>
	/// </summary>
	[JsonPropertyName("user_token")]
	public string UserToken { get; set; } = default!;

}
