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
	/// <para>The Plaid Institution ID associated with the Item. Field is <c>null</c> for Items created via Same Day Micro-deposits.</para>
	/// </summary>
	[JsonPropertyName("institution_id")]
	public string? InstitutionId { get; init; } = default!;

	/// <summary>
	/// <para>The URL registered to receive webhooks for the Item.</para>
	/// </summary>
	[JsonPropertyName("webhook")]
	public string? Webhook { get; init; } = default!;

	/// <summary>
	/// <para>We use standard HTTP response codes for success and failure notifications, and our errors are further classified by <c>error_type</c>. In general, 200 HTTP codes correspond to success, 40X codes are for developer- or user-related failures, and 50X codes are for Plaid-related issues. An Item with a non-<c>null</c> error object will only be part of an API response when calling <c>/item/get</c> to view Item status. Otherwise, error fields will be <c>null</c> if no error has occurred; if an error has occurred, an error code will be returned instead.</para>
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
	/// <para>A list of products that have gone through consent collection for the Item. Only present for those enabled in the <a href="https://plaid.com/docs/link/data-transparency-messaging-migration-guide">Data Transparency</a> beta. If you are not enrolled in Data Transparency, this field is not used.</para>
	/// </summary>
	[JsonPropertyName("consented_products")]
	public IReadOnlyList<Entity.Products>? ConsentedProducts { get; init; } = default!;

	/// <summary>
	/// <para>The RFC 3339 timestamp after which the consent provided by the end user will expire. Upon consent expiration, the item will enter the <c>ITEM_LOGIN_REQUIRED</c> error state. To circumvent the <c>ITEM_LOGIN_REQUIRED</c> error and maintain continuous consent, the end user can reauthenticate via Link’s update mode in advance of the consent expiration time.</para>
	/// <para>Note - This is only relevant for certain OAuth-based institutions. For all other institutions, this field will be null.</para>
	/// </summary>
	[JsonPropertyName("consent_expiration_time")]
	public DateTimeOffset? ConsentExpirationTime { get; init; } = default!;

	/// <summary>
	/// <para>Indicates whether an Item requires user interaction to be updated, which can be the case for Items with some forms of two-factor authentication.</para>
	/// </summary>
	[JsonPropertyName("update_type")]
	public Entity.ItemUpdateTypeEnum UpdateType { get; init; } = default!;

}
