namespace Going.Plaid.User;

/// <summary>
/// <para>UserCreateRequest defines the request schema for <c>/user/create</c></para>
/// </summary>
public partial class UserCreateRequest : RequestBase
{
	/// <summary>
	/// <para>A unique ID representing the end user. Maximum of 128 characters. Typically this will be a user ID number from your application. Personally identifiable information, such as an email address or phone number, should not be used in the <c>client_user_id</c>.</para>
	/// </summary>
	[JsonPropertyName("client_user_id")]
	public string ClientUserId { get; set; } = default!;
}