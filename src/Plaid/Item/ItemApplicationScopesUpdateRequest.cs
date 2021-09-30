namespace Going.Plaid.Item;

/// <summary>
/// <para>ItemApplicationScopesUpdateRequest defines the request schema for <c>/item/application/scopes/update</c></para>
/// </summary>
public class ItemApplicationScopesUpdateRequest : RequestBase
{
	/// <summary>
	/// <para>This field will map to the application ID that is returned from /item/applications/list, or provided to the institution in an oauth redirect.</para>
	/// </summary>
	[JsonPropertyName("application_id")]
	public string ApplicationId { get; set; } = default!;

	/// <summary>
	/// <para>The scopes object</para>
	/// </summary>
	[JsonPropertyName("scopes")]
	public Entity.Scopes Scopes { get; set; } = default!;

	/// <summary>
	/// <para>When scopes are updated during enrollment, this field must be populated with the state sent to the partner in the OAuth Login URI. This field is required when the context is <c>ENROLLMENT</c>.</para>
	/// </summary>
	[JsonPropertyName("state")]
	public string State { get; set; } = default!;

	/// <summary>
	/// <para>An indicator for when scopes are being updated. When scopes are updated via enrollment (i.e. OAuth), the partner must send <c>ENROLLMENT</c>. When scopes are updated in a post-enrollment view, the partner must send <c>PORTAL</c>.</para>
	/// </summary>
	[JsonPropertyName("context")]
	public Entity.ScopesContext Context { get; set; } = default!;
}