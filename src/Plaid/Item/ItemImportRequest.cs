namespace Going.Plaid.Item;

/// <summary>
/// <para>ItemImportRequest defines the request schema for <c>/item/import</c></para>
/// </summary>
public partial class ItemImportRequest : RequestBase
{
	/// <summary>
	/// <para>Array of product strings</para>
	/// </summary>
	[JsonPropertyName("products")]
	public IReadOnlyList<Entity.Products> Products { get; set; } = default!;

	/// <summary>
	/// <para>Object of user ID and auth token pair, permitting Plaid to aggregate a user’s accounts</para>
	/// </summary>
	[JsonPropertyName("user_auth")]
	public Entity.ItemImportRequestUserAuth UserAuth { get; set; } = default!;

	/// <summary>
	/// <para>An optional object to configure <c>/item/import</c> request.</para>
	/// </summary>
	[JsonPropertyName("options")]
	public Entity.ItemImportRequestOptions Options { get; set; } = default!;
}