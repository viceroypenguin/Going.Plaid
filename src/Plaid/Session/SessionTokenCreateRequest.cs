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
	/// <para>SessionTokenCreateRequestUser defines per-session user-specific data for <c>/session/token/create</c></para>
	/// </summary>
	[JsonPropertyName("user")]
	public Entity.SessionTokenCreateRequestUser? User { get; set; } = default!;

	/// <summary>
	/// <para>A URI indicating the destination where a user should be forwarded after completing the Link flow; used to support OAuth authentication flows when launching Link in the browser or another app. The <c>redirect_uri</c> should not contain any query parameters. When used in Production, must be an https URI. To specify any subdomain, use <c>*</c> as a wildcard character, e.g. <c>https://*.example.com/oauth.html</c>. Note that any redirect URI must also be added to the Allowed redirect URIs list in the <a href="https://dashboard.plaid.com/team/api">developer dashboard</a>. If initializing on Android, <c>android_package_name</c> must be specified instead and <c>redirect_uri</c> should be left blank.</para>
	/// </summary>
	[JsonPropertyName("redirect_uri")]
	public string? RedirectUri { get; set; } = default!;

}
