namespace Going.Plaid.Sandbox;

/// <summary>
/// <para>SandboxUserResetLoginRequest defines the request schema for <c>/sandbox/user/reset_login</c></para>
/// </summary>
public partial class SandboxUserResetLoginRequest : RequestBase
{
	/// <summary>
	/// <para>The user token associated with the User data is being requested for.</para>
	/// </summary>
	[JsonPropertyName("user_token")]
	public string UserToken { get; set; } = default!;

	/// <summary>
	/// <para>An array of <c>item_id</c>s associated with the User to be reset.  If empty or <c>null</c>, this field will default to resetting all Items associated with the User.</para>
	/// </summary>
	[JsonPropertyName("item_ids")]
	public IReadOnlyList<string>? ItemIds { get; set; } = default!;

}
