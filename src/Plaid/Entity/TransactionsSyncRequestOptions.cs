namespace Going.Plaid.Entity;

/// <summary>
/// <para>An optional object to be used with the request. If specified, <c>options</c> must not be <c>null</c>.</para>
/// </summary>
public class TransactionsSyncRequestOptions
{
	/// <summary>
	/// <para>Include the raw unparsed transaction description from the financial institution. This field is disabled by default. If you need this information in addition to the parsed data provided, contact your Plaid Account Manager or submit a <a href="https://dashboard.plaid.com/support/new/product-and-development/product-troubleshooting/product-functionality">Support request</a>.</para>
	/// </summary>
	[JsonPropertyName("include_original_description")]
	public bool? IncludeOriginalDescription { get; set; } = default!;

	/// <summary>
	/// <para>Include the <a href="https://plaid.com/docs/api/products/transactions/#transactions-sync-response-added-personal-finance-category"><c>personal_finance_category</c></a> object in the response.</para>
	/// <para>All implementations are encouraged to use set this field to <c>true</c> and to use the <c>personal_finance_category</c> instead of <c>category</c> for more meaningful and accurate categorization.</para>
	/// <para>See the <a href="https://plaid.com/documents/transactions-personal-finance-category-taxonomy.csv"><c>taxonomy csv file</c></a> for a full list of personal finance categories.</para>
	/// </summary>
	[JsonPropertyName("include_personal_finance_category")]
	public bool? IncludePersonalFinanceCategory { get; set; } = default!;

	/// <summary>
	/// <para>Include counterparties and extra merchant fields in the transaction. This field is disabled by default. If you need this information in addition to the parsed data provided, contact your Plaid Account Manager.</para>
	/// </summary>
	[JsonPropertyName("include_logo_and_counterparty_beta")]
	public bool? IncludeLogoAndCounterpartyBeta { get; set; } = default!;
}