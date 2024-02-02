namespace Going.Plaid.Entity;

/// <summary>
/// <para>A grouping of the Plaid produced transaction enrichment fields.</para>
/// </summary>
public record Enrichments
{
	/// <summary>
	/// <para>The check number of the transaction. This field is only populated for check transactions.</para>
	/// </summary>
	[JsonPropertyName("check_number")]
	public string? CheckNumber { get; init; } = default!;

	/// <summary>
	/// <para>The counterparties present in the transaction. Counterparties, such as the merchant or the financial institution, are extracted by Plaid from the raw description.</para>
	/// </summary>
	[JsonPropertyName("counterparties")]
	public IReadOnlyList<Entity.Counterparty> Counterparties { get; init; } = default!;

	/// <summary>
	/// <para>A unique, stable, Plaid-generated ID that maps to the primary counterparty.</para>
	/// </summary>
	[JsonPropertyName("entity_id")]
	public string? EntityId { get; init; } = default!;

	/// <summary>
	/// <para>The ID of the legacy category to which this transaction belongs. For a full list of legacy categories, see <a href="https://plaid.com/docs/api/products/transactions/#categoriesget"><c>/categories/get</c></a>.</para>
	/// <para>We recommend using the <c>personal_finance_category</c> for transaction categorization to obtain the best results.</para>
	/// </summary>
	[JsonPropertyName("legacy_category_id")]
	public string? LegacyCategoryId { get; init; } = default!;

	/// <summary>
	/// <para>A hierarchical array of the legacy categories to which this transaction belongs. For a full list of legacy categories, see <a href="https://plaid.com/docs/api/products/transactions/#categoriesget"><c>/categories/get</c></a>.</para>
	/// <para>We recommend using the <c>personal_finance_category</c> for transaction categorization to obtain the best results.</para>
	/// </summary>
	[JsonPropertyName("legacy_category")]
	public IReadOnlyList<string>? LegacyCategory { get; init; } = default!;

	/// <summary>
	/// <para>A representation of where a transaction took place</para>
	/// </summary>
	[JsonPropertyName("location")]
	public Entity.Location Location { get; init; } = default!;

	/// <summary>
	/// <para>The URL of a logo associated with this transaction, if available. The logo will always be 100×100 pixel PNG file.</para>
	/// </summary>
	[JsonPropertyName("logo_url")]
	public string? LogoUrl { get; init; } = default!;

	/// <summary>
	/// <para>The name of the primary counterparty, such as the merchant or the financial institution, as extracted by Plaid from the raw description.</para>
	/// </summary>
	[JsonPropertyName("merchant_name")]
	public string? MerchantName { get; init; } = default!;

	/// <summary>
	/// <para>The channel used to make a payment.</para>
	/// </summary>
	[JsonPropertyName("payment_channel")]
	public Entity.PaymentChannel PaymentChannel { get; init; } = default!;

	/// <summary>
	/// <para>The phone number associated with the counterparty in E. 164 format. If there is a location match (i.e. a street address is returned in the location object), the phone number will be location specific.</para>
	/// </summary>
	[JsonPropertyName("phone_number")]
	public string? PhoneNumber { get; init; } = default!;

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
	public string PersonalFinanceCategoryIconUrl { get; init; } = default!;

	/// <summary>
	/// <para>Insights relating to expenses and deposits that are predicted to occur on a scheduled basis, such as biweekly, monthly, or annually.</para>
	/// <para>Common examples include loan payments, bill payments, subscriptions, and payroll income.</para>
	/// <para>This is a beta field, available to all users.</para>
	/// </summary>
	[JsonPropertyName("recurrence")]
	public Entity.Recurrence? Recurrence { get; init; } = default!;

	/// <summary>
	/// <para>The website associated with this transaction.</para>
	/// </summary>
	[JsonPropertyName("website")]
	public string? Website { get; init; } = default!;

}
