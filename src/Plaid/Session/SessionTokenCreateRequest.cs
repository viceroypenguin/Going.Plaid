namespace Going.Plaid.Session;

/// <summary>
/// <para>SessionTokenCreateRequest defines the request schema for <c>/session/token/create</c></para>
/// </summary>
public partial class SessionTokenCreateRequest : RequestBase
{
	/// <summary>
	/// <para>The id of a template defined in Plaid Dashboard</para>
	/// </summary>
	[JsonPropertyName("template_id")]
	public string TemplateId { get; set; } = default!;

	/// <summary>
	/// <para>Details about the end user. Required if a root-level <c>user_id</c> is not provided.</para>
	/// </summary>
	[JsonPropertyName("user")]
	public Entity.SessionTokenCreateRequestUser? User { get; set; } = default!;

	/// <summary>
	/// <para>A URI indicating the destination where a user should be forwarded after completing the Link flow; used to support OAuth authentication flows when launching Link in the browser or another app. The <c>redirect_uri</c> should not contain any query parameters. When used in Production, must be an https URI. To specify any subdomain, use <c>*</c> as a wildcard character, e.g. <c>https://*.example.com/oauth.html</c>. Note that any redirect URI must also be added to the Allowed redirect URIs list in the <a href="https://dashboard.plaid.com/team/api">developer dashboard</a>. If initializing on Android, <c>android_package_name</c> must be specified instead and <c>redirect_uri</c> should be left blank.</para>
	/// </summary>
	[JsonPropertyName("redirect_uri")]
	public string? RedirectUri { get; set; } = default!;

	/// <summary>
	/// <para>The name of your app's Android package. Required if using the session token to initialize Layer on Android. Any package name specified here must also be added to the Allowed Android package names setting on the <a href="https://dashboard.plaid.com/team/api">developer dashboard</a>. When creating a session token for initializing Layer on other platforms, <c>android_package_name</c> must be left blank and <c>redirect_uri</c> should be used instead.</para>
	/// </summary>
	[JsonPropertyName("android_package_name")]
	public string? AndroidPackageName { get; set; } = default!;

	/// <summary>
	/// <para>The destination URL to which any webhooks should be sent. If you use the same webhook listener for all Sandbox or all Production activity, set this value in the Layer template editor in the Dashboard instead. Only provide a value in this field if you need to use multiple webhook URLs per environment (an uncommon use case). If provided, a value in this field will take priority over webhook values set in the Layer template editor.</para>
	/// </summary>
	[JsonPropertyName("webhook")]
	public string? Webhook { get; set; } = default!;

	/// <summary>
	/// <para>A unique user identifier, created by <c>/user/create</c>. Integrations that began using <c>/user/create</c> after December 10, 2025 use this field to identify a user instead of the <c>user_token</c>. For more details, see <a href="https://plaid.com/docs/api/users/user-apis">new user APIs</a>.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string? UserId { get; set; } = default!;

}
