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
}