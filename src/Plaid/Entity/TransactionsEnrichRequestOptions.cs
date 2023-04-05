namespace Going.Plaid.Entity;

/// <summary>
/// <para>An optional object to be used with the request.</para>
/// </summary>
public class TransactionsEnrichRequestOptions
{
	/// <summary>
	/// <para>Include <c>legacy_category</c> and <c>legacy_category_id</c> in the response (in addition to the default <c>personal_finance_category</c>).</para>
	/// <para>Categories are based on Plaid's legacy taxonomy. For a full list of legacy categories, see <a href="https://plaid.com/docs/api/products/transactions/#categoriesget"><c>/categories/get</c></a>.</para>
	/// </summary>
	[JsonPropertyName("include_legacy_category")]
	public bool? IncludeLegacyCategory { get; set; } = default!;
}