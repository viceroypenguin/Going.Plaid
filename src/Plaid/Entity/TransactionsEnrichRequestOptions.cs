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

	/// <summary>
	/// <para>Optional parameter that specifies which version of the personal finance category taxonomy to return. The v2 taxonomy is defined <a href="https://docs.google.com/spreadsheets/d/e/2PACX-1vRUQR6BdYCwu7libfEUUA0U4TYfkyxpAUOSCj_unpv6OYCJMhIC0_PNrJnnki0At3LAG0PgT3aY7hRz/pubhtml">here</a>. The legacy v1 taxonomy is defined <a href="https://docs.google.com/spreadsheets/d/e/2PACX-1vQb96YxbnLdHbAROh1Dx7BaSpChnAIEKp1zZZFLBBpGbiLtPR3JTtxzvQ8mF4kU0StL8Y16WEpUd5P2/pubhtml">here</a>.</para>
	/// <para>If you enabled any Financial Insights products before October 2025 you will receive a default of <c>v1</c> taxonomy and may request <c>v2</c> by explicitly setting this field to <c>v2</c>.</para>
	/// <para>If you enabled any Financial Insights products on or after October 2025 you may only receive <c>v2</c> taxonomy.</para>
	/// </summary>
	[JsonPropertyName("personal_finance_category_version")]
	public string? PersonalFinanceCategoryVersion { get; set; } = default!;

}
