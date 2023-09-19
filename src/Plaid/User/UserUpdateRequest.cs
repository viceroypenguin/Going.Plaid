namespace Going.Plaid.User;

/// <summary>
/// <para>UserUpdateRequest defines the request schema for <c>/user/update</c></para>
/// </summary>
public partial class UserUpdateRequest : RequestBase
{
	/// <summary>
	/// <para>The user token associated with the User data is being requested for.</para>
	/// </summary>
	[JsonPropertyName("user_token")]
	public string UserToken { get; set; } = default!;

	/// <summary>
	/// <para>ConsumerReportUserIdentity defines the user identity data collected for consumer report purpose. This field is required to be set if you later use the created user for consumer report purpose.</para>
	/// </summary>
	[JsonPropertyName("consumer_report_user_identity")]
	public Entity.ConsumerReportUserIdentity? ConsumerReportUserIdentity { get; set; } = default!;
}