namespace Going.Plaid.Entity;

/// <summary>
/// <para>An optional object to be used with the request. If specified, <c>options</c> must not be <c>null</c>.</para>
/// </summary>
public class TransactionsGetRequestOptions
{
	/// <summary>
	/// <para>A list of <c>account_ids</c> to retrieve for the Item</para>
	/// <para>Note: An error will be returned if a provided <c>account_id</c> is not associated with the Item.</para>
	/// </summary>
	[JsonPropertyName("account_ids")]
	public IReadOnlyList<string>? AccountIds { get; set; } = default!;

	/// <summary>
	/// <para>The number of transactions to fetch.</para>
	/// </summary>
	[JsonPropertyName("count")]
	public int? Count { get; set; } = default!;

	/// <summary>
	/// <para>The number of transactions to skip. The default value is 0.</para>
	/// </summary>
	[JsonPropertyName("offset")]
	public int? Offset { get; set; } = default!;

	/// <summary>
	/// <para>Include the raw unparsed transaction description from the financial institution. This field is disabled by default. If you need this information in addition to the parsed data provided, contact your Plaid Account Manager, or submit a <a href="https://dashboard.plaid.com/support/new/product-and-development/product-troubleshooting/product-functionality">Support request</a> .</para>
	/// </summary>
	[JsonPropertyName("include_original_description")]
	public bool? IncludeOriginalDescription { get; set; } = default!;

	/// <summary>
	/// <para>Please use <a href="https://plaid.com/docs/api/products/transactions/#transactions-get-request-options-include-personal-finance-category"><c>include_personal_finance_category</c></a> instead.</para>
	/// </summary>
	[JsonPropertyName("include_personal_finance_category_beta")]
	public bool? IncludePersonalFinanceCategoryBeta { get; set; } = default!;

	/// <summary>
	/// <para>Include the <a href="https://plaid.com/docs/api/products/transactions/#transactions-get-response-transactions-personal-finance-category"><c>personal_finance_category</c></a> object in the response.</para>
	/// <para>See the <a href="https://plaid.com/documents/transactions-personal-finance-category-taxonomy.csv"><c>taxonomy csv file</c></a> for a full list of personal finance categories.</para>
	/// <para>We’re introducing Category Rules - a new beta endpoint that will enable you to change the <c>personal_finance_category</c> for a transaction based on your users’ needs. When rules are set, the selected category will override the Plaid provided category. To learn more, send a note to transactions-feedback@plaid.com.</para>
	/// </summary>
	[JsonPropertyName("include_personal_finance_category")]
	public bool? IncludePersonalFinanceCategory { get; set; } = default!;

	/// <summary>
	/// <para>Include counterparties and extran merchant fields in the transaction. This field is disabled by default. If you need this information in addition to the parsed data provided, contact your Plaid Account Manager.</para>
	/// </summary>
	[JsonPropertyName("include_logo_and_counterparty_beta")]
	public bool? IncludeLogoAndCounterpartyBeta { get; set; } = default!;
}