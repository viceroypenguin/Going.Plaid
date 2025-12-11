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

	/// <summary>
	/// <para>ClientUserIdentity is the shared user identity construct across /user/* routes.</para>
	/// </summary>
	[JsonPropertyName("identity")]
	public Entity.ClientUserIdentity? Identity { get; set; } = default!;

	/// <summary>
	/// <para>A unique ID representing a CRA reseller's end customer. Maximum of 128 characters.</para>
	/// </summary>
	[JsonPropertyName("end_customer")]
	public string? EndCustomer { get; set; } = default!;

	/// <summary>
	/// <para>This field is only used by integrations created before December 10, 2025. All other integrations must use the <c>identity</c> object instead. For more details, see <a href="https://plaid.com/docs/api/users/user-apis">new user APIs</a>.</para>
	/// <para>To create a Plaid Check Consumer Report for a user when using a <c>user_token</c>, this field must be present. If this field is not provided during user token creation, you can add it to the user later by calling <c>/user/update</c>. Once the field has been added to the user, you will be able to call <c>/link/token/create</c> with a non-empty <c>consumer_report_permissible_purpose</c> (which will automatically create a Plaid Check Consumer Report), or call <c>/cra/check_report/create</c> for that user.</para>
	/// </summary>
	[JsonPropertyName("consumer_report_user_identity")]
	public Entity.ConsumerReportUserIdentity? ConsumerReportUserIdentity { get; set; } = default!;

	/// <summary>
	/// <para>When <c>true</c>, a new user will be created and a <c>user_id</c> will be returned. Otherwise, a legacy user will be created and a <c>user_token</c> will be returned.</para>
	/// </summary>
	[JsonPropertyName("with_upgraded_user")]
	public bool? WithUpgradedUser { get; set; } = default!;

}
