namespace Going.Plaid.Item;

/// <summary>
/// <para>ItemImportRequest defines the request schema for <c>/item/import</c></para>
/// </summary>
public partial class ItemImportRequest : RequestBase
{
	/// <summary>
	/// <para>The Plaid Institution ID associated with the Item. Most callers omit this field; Plaid resolves your institution automatically. If your organization has multiple institutions, contact Plaid to determine whether you should send it.</para>
	/// </summary>
	[JsonPropertyName("institution_id")]
	public string? InstitutionId { get; set; } = default!;

	/// <summary>
	/// <para>Array of product strings. Sent only by a Plaid-internal caller, the Data Partner Dashboard validation tool; external callers never need it. Not required for Permissions Manager callers, who authenticate with <c>user_auth.user_id</c>.</para>
	/// </summary>
	[JsonPropertyName("products")]
	public IReadOnlyList<Entity.Products>? Products { get; set; } = default!;

	/// <summary>
	/// <para>Object of user ID and auth token pair, permitting Plaid to aggregate a user's accounts</para>
	/// </summary>
	[JsonPropertyName("user_auth")]
	public Entity.ItemImportRequestUserAuth UserAuth { get; set; } = default!;

	/// <summary>
	/// <para>An optional object to configure <c>/item/import</c> request. Retained for the legacy Plaid Exchange integration; not required for Permissions Manager callers.</para>
	/// </summary>
	[JsonPropertyName("options")]
	[Obsolete]
	public Entity.ItemImportRequestOptions? Options { get; set; } = default!;

}
