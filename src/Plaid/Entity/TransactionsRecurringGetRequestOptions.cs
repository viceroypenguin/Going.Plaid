namespace Going.Plaid.Entity;

/// <summary>
/// <para>An optional object to be used with the request. If specified, <c>options</c> must not be <c>null</c>.</para>
/// </summary>
public class TransactionsRecurringGetRequestOptions
{
	/// <summary>
	/// <para>Include the <a href="https://plaid.com/docs/api/products/transactions/#transactions-get-response-transactions-personal-finance-category"><c>personal_finance_category</c></a> object for each transaction stream in the response.</para>
	/// <para>See the <a href="https://plaid.com/documents/transactions-personal-finance-category-taxonomy.csv"><c>taxonomy csv file</c></a> for a full list of personal finance categories.</para>
	/// </summary>
	[JsonPropertyName("include_personal_finance_category")]
	public bool IncludePersonalFinanceCategory { get; set; } = default!;
}