namespace Going.Plaid.Entity;

/// <summary>
/// <para>Metadata about the Item.</para>
/// </summary>
public record Item
{
	/// <summary>
	/// <para>The Plaid Item ID. The <c>item_id</c> is always unique; linking the same account at the same institution twice will result in two Items with different <c>item_id</c> values. Like all Plaid identifiers, the <c>item_id</c> is case-sensitive.</para>
	/// </summary>
	[JsonPropertyName("item_id")]
	public string ItemId { get; init; } = default!;

	/// <summary>
	/// <para>The Plaid Institution ID associated with the Item. Field is <c>null</c> for Items created without an institution connection, such as Items created via Same Day Micro-deposits.</para>
	/// </summary>
	[JsonPropertyName("institution_id")]
	public string? InstitutionId { get; init; } = default!;

	/// <summary>
	/// <para>The name of the institution associated with the Item. Field is <c>null</c> for Items created without an institution connection, such as Items created via Same Day Micro-deposits.</para>
	/// </summary>
	[JsonPropertyName("institution_name")]
	public string? InstitutionName { get; init; } = default!;

	/// <summary>
	/// <para>The URL registered to receive webhooks for the Item.</para>
	/// </summary>
	[JsonPropertyName("webhook")]
	public string? Webhook { get; init; } = default!;

	/// <summary>
	/// <para>The method used to populate Auth data for the Item. This field is only populated for Items that have had Auth numbers data set on at least one of its accounts, and will be <c>null</c> otherwise. For info about the various flows, see our <a href="https://plaid.com/docs/auth/coverage/">Auth coverage documentation</a>.</para>
	/// </summary>
	[JsonPropertyName("auth_method")]
	public Entity.ItemAuthMethod? AuthMethod { get; init; } = default!;

	/// <summary>
	/// <para>Errors are identified by <c>error_code</c> and categorized by <c>error_type</c>. Use these in preference to HTTP status codes to identify and handle specific errors. HTTP status codes are set and provide the broadest categorization of errors: 4xx codes are for developer- or user-related errors, and 5xx codes are for Plaid-related errors, and the status will be 2xx in non-error cases. An Item with a non-<c>null</c> error object will only be part of an API response when calling <c>/item/get</c> to view Item status. Otherwise, error fields will be <c>null</c> if no error has occurred; if an error has occurred, an error code will be returned instead.</para>
	/// </summary>
	[JsonPropertyName("error")]
	public Entity.PlaidError? Error { get; init; } = default!;

	/// <summary>
	/// <para>A list of products available for the Item that have not yet been accessed. The contents of this array will be mutually exclusive with <c>billed_products</c>.</para>
	/// </summary>
	[JsonPropertyName("available_products")]
	public IReadOnlyList<Entity.Products> AvailableProducts { get; init; } = default!;

	/// <summary>
	/// <para>A list of products that have been billed for the Item. The contents of this array will be mutually exclusive with <c>available_products</c>. Note - <c>billed_products</c> is populated in all environments but only requests in Production are billed. Also note that products that are billed on a pay-per-call basis rather than a pay-per-Item basis, such as <c>balance</c>, will not appear here.</para>
	/// </summary>
	[JsonPropertyName("billed_products")]
	public IReadOnlyList<Entity.Products> BilledProducts { get; init; } = default!;

	/// <summary>
	/// <para>A list of products added to the Item. In almost all cases, this will be the same as the <c>billed_products</c> field. For some products, it is possible for the product to be added to an Item but not yet billed (e.g. Assets, before <c>/asset_report/create</c> has been called, or Auth or Identity when added as Optional Products but before their endpoints have been called), in which case the product may appear in <c>products</c> but not in <c>billed_products</c>.</para>
	/// </summary>
	[JsonPropertyName("products")]
	public IReadOnlyList<Entity.Products>? Products { get; init; } = default!;

	/// <summary>
	/// <para>A list of products that the user has consented to for the Item via <a href="https://plaid.com/docs/link/data-transparency-messaging-migration-guide">Data Transparency Messaging</a>. This will consist of all products where both of the following are true: the user has consented to the required data scopes for that product and you have Production access for that product.</para>
	/// </summary>
	[JsonPropertyName("consented_products")]
	public IReadOnlyList<Entity.Products>? ConsentedProducts { get; init; } = default!;

	/// <summary>
	/// <para>The date and time at which the Item's access consent will expire, in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format. If the Item does not have consent expiration scheduled, this field will be <c>null</c>. Currently, only institutions in Europe and a small number of institutions in the US have expiring consent. Closer to the 1033 compliance deadline of April 1, 2026, expiration times will be populated more widely. For more details, see <a href="https://plaid.com/docs/link/data-transparency-messaging-migration-guide/#consent-expiration-and-reauthorization">Data Transparency Messaging consent expiration</a>.</para>
	/// </summary>
	[JsonPropertyName("consent_expiration_time")]
	public DateTimeOffset? ConsentExpirationTime { get; init; } = default!;

	/// <summary>
	/// <para>Indicates whether an Item requires user interaction to be updated, which can be the case for Items with some forms of two-factor authentication.</para>
	/// </summary>
	[JsonPropertyName("update_type")]
	public Entity.ItemUpdateTypeEnum UpdateType { get; init; } = default!;

}
