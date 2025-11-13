namespace Going.Plaid.Entity;

/// <summary>
/// <para>A grouping of the Plaid produced transaction enhancement fields.</para>
/// </summary>
public record Enhancements
{
	/// <summary>
	/// <para>The name of the primary counterparty, such as the merchant or the financial institution, as extracted by Plaid from the raw description.</para>
	/// </summary>
	[JsonPropertyName("merchant_name")]
	public string? MerchantName { get; init; } = default!;

	/// <summary>
	/// <para>The website associated with this transaction, if available.</para>
	/// </summary>
	[JsonPropertyName("website")]
	public string? Website { get; init; } = default!;

	/// <summary>
	/// <para>The URL of a logo associated with this transaction, if available. The logo will always be 100×100 pixel PNG file.</para>
	/// </summary>
	[JsonPropertyName("logo_url")]
	public string? LogoUrl { get; init; } = default!;

	/// <summary>
	/// <para>The check number of the transaction. This field is only populated for check transactions.</para>
	/// </summary>
	[JsonPropertyName("check_number")]
	public string? CheckNumber { get; init; } = default!;

	/// <summary>
	/// <para>The channel used to make a payment.</para>
	/// </summary>
	[JsonPropertyName("payment_channel")]
	public Entity.PaymentChannel PaymentChannel { get; init; } = default!;

	/// <summary>
	/// <para>The ID of the category to which this transaction belongs. For a full list of categories, see <a href="https://plaid.com/docs/api/products/transactions/#categoriesget"><c>/categories/get</c></a>.</para>
	/// </summary>
	[JsonPropertyName("category_id")]
	public string? CategoryId { get; init; } = default!;

	/// <summary>
	/// <para>A hierarchical array of the categories to which this transaction belongs. For a full list of categories, see <a href="https://plaid.com/docs/api/products/transactions/#categoriesget"><c>/categories/get</c></a>.</para>
	/// </summary>
	[JsonPropertyName("category")]
	public IReadOnlyList<string> Category { get; init; } = default!;

	/// <summary>
	/// <para>A representation of where a transaction took place. Location data is provided only for transactions at physical locations, not for online transactions. Location data availability depends primarily on the merchant and is most likely to be populated for transactions at large retail chains; small, local businesses are less likely to have location data available.</para>
	/// </summary>
	[JsonPropertyName("location")]
	public Entity.Location Location { get; init; } = default!;

	/// <summary>
	/// <para>Information describing the intent of the transaction. Most relevant for personal finance use cases, but not limited to such use cases.</para>
	/// <para>See the <a href="https://plaid.com/documents/transactions-personal-finance-category-taxonomy.csv"><c>taxonomy CSV file</c></a> for a full list of personal finance categories. If you are migrating to personal finance categories from the legacy categories, also refer to the <a href="https://plaid.com/docs/transactions/pfc-migration/"><c>migration guide</c></a>.</para>
	/// </summary>
	[JsonPropertyName("personal_finance_category")]
	public Entity.PersonalFinanceCategory? PersonalFinanceCategory { get; init; } = default!;

	/// <summary>
	/// <para>The URL of an icon associated with the primary personal finance category. The icon will always be 100×100 pixel PNG file.</para>
	/// </summary>
	[JsonPropertyName("personal_finance_category_icon_url")]
	public string? PersonalFinanceCategoryIconUrl { get; init; } = default!;

	/// <summary>
	/// <para>The counterparties present in the transaction. Counterparties, such as the merchant or the financial institution, are extracted by Plaid from the raw description.</para>
	/// </summary>
	[JsonPropertyName("counterparties")]
	public IReadOnlyList<Entity.Counterparty>? Counterparties { get; init; } = default!;

}
