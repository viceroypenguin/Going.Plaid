namespace Going.Plaid.Entity;

/// <summary>
/// <para>An optional object to be used with the request. If specified, <c>options</c> must not be <c>null</c>.</para>
/// </summary>
public class TransactionsSyncRequestOptions
{
	/// <summary>
	/// <para>Include the raw unparsed transaction description from the financial institution.</para>
	/// </summary>
	[JsonPropertyName("include_original_description")]
	public bool? IncludeOriginalDescription { get; set; } = default!;

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
	/// <para>This field only applies to calls for Items where the Transactions product has not already been initialized (i.e., by specifying <c>transactions</c> in the <c>products</c>, <c>required_if_supported_products</c>, or <c>optional_products</c> array when calling <c>/link/token/create</c> or by making a previous call to <c>/transactions/sync</c> or <c>/transactions/get</c>). In those cases, the field controls the maximum number of days of transaction history that Plaid will request from the financial institution. The more transaction history is requested, the longer the historical update poll will take. If no value is specified, 90 days of history will be requested by default.</para>
	/// <para>If you are initializing your Items with transactions during the <c>/link/token/create</c> call (e.g. by including <c>transactions</c> in the <c>/link/token/create</c> <c>products</c> array), you must use the <a href="https://plaid.com/docs/api/link/#link-token-create-request-transactions-days-requested"><c>transactions.days_requested</c></a> field in the <c>/link/token/create</c> request instead of in the <c>/transactions/sync</c> request.</para>
	/// <para>If the Item has already been initialized with the Transactions product, this field will have no effect. The maximum amount of transaction history to request on an Item cannot be updated if Transactions has already been added to the Item. To request older transaction history on an Item where Transactions has already been added, you must delete the Item via <c>/item/remove</c> and send the user through Link to create a new Item. </para>
	/// <para>Customers using <a href="https://plaid.com/docs/api/products/transactions/#transactionsrecurringget">Recurring Transactions</a> should request at least 180 days of history for optimal results.</para>
	/// </summary>
	[JsonPropertyName("days_requested")]
	public int? DaysRequested { get; set; } = default!;

}
