namespace Going.Plaid.Entity;

/// <summary>
/// <para>An optional object to be used with the request. If specified, <c>options</c> must not be <c>null</c>.</para>
/// </summary>
public class TransactionsSyncRequestOptions
{
	/// <summary>
	/// <para>Include the raw unparsed transaction description from the financial institution. This field is disabled by default. If you need this information in addition to the parsed data provided, contact your Plaid Account Manager.</para>
	/// </summary>
	[JsonPropertyName("include_original_description")]
	public bool? IncludeOriginalDescription { get; set; } = default!;

	/// <summary>
	/// <para>Include the <a href="https://plaid.com/docs/api/products/transactions/#transactions-sync-response-transactions-personal-finance-category"><c>personal_finance_category</c></a> object in the response.</para>
	/// <para>See the <a href="https://plaid.com/documents/transactions-personal-finance-category-taxonomy.csv"><c>taxonomy csv file</c></a> for a full list of personal finance categories.</para>
	/// </summary>
	[JsonPropertyName("include_personal_finance_category")]
	public bool IncludePersonalFinanceCategory { get; set; } = default!;
}