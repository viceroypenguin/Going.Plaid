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
	/// <para>Include the raw unparsed transaction description from the financial institution.</para>
	/// </summary>
	[JsonPropertyName("include_original_description")]
	public bool? IncludeOriginalDescription { get; set; } = default!;

	/// <summary>
	/// <para>Personal finance categories are now returned by default.</para>
	/// </summary>
	[JsonPropertyName("include_personal_finance_category_beta")]
	[Obsolete]
	public bool? IncludePersonalFinanceCategoryBeta { get; set; } = default!;

	/// <summary>
	/// <para>Personal finance categories are now returned by default.</para>
	/// </summary>
	[JsonPropertyName("include_personal_finance_category")]
	[Obsolete]
	public bool? IncludePersonalFinanceCategory { get; set; } = default!;

	/// <summary>
	/// <para>Counterparties and extra merchant fields are now returned by default.</para>
	/// </summary>
	[JsonPropertyName("include_logo_and_counterparty_beta")]
	[Obsolete]
	public bool? IncludeLogoAndCounterpartyBeta { get; set; } = default!;

	/// <summary>
	/// <para>Optional parameter that specifies which version of the personal finance category taxonomy to return. The v2 taxonomy is defined <a href="https://docs.google.com/spreadsheets/d/e/2PACX-1vRUQR6BdYCwu7libfEUUA0U4TYfkyxpAUOSCj_unpv6OYCJMhIC0_PNrJnnki0At3LAG0PgT3aY7hRz/pubhtml">here</a>. The legacy v1 taxonomy is defined <a href="https://docs.google.com/spreadsheets/d/e/2PACX-1vQb96YxbnLdHbAROh1Dx7BaSpChnAIEKp1zZZFLBBpGbiLtPR3JTtxzvQ8mF4kU0StL8Y16WEpUd5P2/pubhtml">here</a>.</para>
	/// <para>If you enabled any Financial Insights products before October 2025 you will receive a default of <c>v1</c> taxonomy and may request <c>v2</c> by explicitly setting this field to <c>v2</c>.</para>
	/// <para>If you enabled any Financial Insights products on or after October 2025 you may only receive <c>v2</c> taxonomy.</para>
	/// </summary>
	[JsonPropertyName("personal_finance_category_version")]
	public string? PersonalFinanceCategoryVersion { get; set; } = default!;

	/// <summary>
	/// <para>This field only applies to calls for Items where the Transactions product has not already been initialized (i.e. by specifying <c>transactions</c> in the <c>products</c>, <c>optional_products</c>, or <c>required_if_consented_products</c> array when calling <c>/link/token/create</c> or by making a previous call to <c>/transactions/sync</c> or <c>/transactions/get</c>). In those cases, the field controls the maximum number of days of transaction history that Plaid will request from the financial institution. The more transaction history is requested, the longer the historical update poll will take. If no value is specified, 90 days of history will be requested by default. If a value under 30 is provided, a minimum of 30 days of history will be requested.</para>
	/// <para>If you are initializing your Items with transactions during the <c>/link/token/create</c> call (e.g. by including <c>transactions</c> in the <c>/link/token/create</c> <c>products</c> array), you must use the <a href="https://plaid.com/docs/api/link/#link-token-create-request-transactions-days-requested"><c>transactions.days_requested</c></a> field in the <c>/link/token/create</c> request instead of in the <c>/transactions/get</c> request.</para>
	/// <para>If the Item has already been initialized with the Transactions product, this field will have no effect. The maximum amount of transaction history to request on an Item cannot be updated if Transactions has already been added to the Item. To request older transaction history on an Item where Transactions has already been added, you must delete the Item via <c>/item/remove</c> and send the user through Link to create a new Item.</para>
	/// <para>Customers using <a href="https://plaid.com/docs/api/products/transactions/#transactionsrecurringget">Recurring Transactions</a> should request at least 180 days of history for optimal results.</para>
	/// </summary>
	[JsonPropertyName("days_requested")]
	public int? DaysRequested { get; set; } = default!;

}
