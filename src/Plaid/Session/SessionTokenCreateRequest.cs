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

}
