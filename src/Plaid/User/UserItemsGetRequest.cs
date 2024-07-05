namespace Going.Plaid.User;

/// <summary>
/// <para>UserItemsGetRequest defines the request schema for <c>/user/items/get</c></para>
/// </summary>
public partial class UserItemsGetRequest : RequestBase
{
	/// <summary>
	/// <para>The user token associated with the User data is being requested for.</para>
	/// </summary>
	[JsonPropertyName("user_token")]
	public string UserToken { get; set; } = default!;

}
