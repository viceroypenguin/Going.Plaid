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
	/// <para>Personal finance categories are now returned by default.</para>
	/// </summary>
	[JsonPropertyName("include_personal_finance_category")]
	public bool? IncludePersonalFinanceCategory { get; set; } = default!;

	/// <summary>
	/// <para>Counterparties and extra merchant fields are now returned by default.</para>
	/// </summary>
	[JsonPropertyName("include_logo_and_counterparty_beta")]
	public bool? IncludeLogoAndCounterpartyBeta { get; set; } = default!;

	/// <summary>
	/// <para>This option only applies to calls for Items that were not initialized with Transactions during Link and are now adding the Transactions product to the Item for the first time. In these cases, this option controls the maximum number of days of transaction history that Plaid will request from the financial institution. For developer accounts created after December 3, 2023, if no value is specified, this will default to 90 days. For developer accounts created on December 3, 2023 or earlier, if no value is specified, this will default to 730 days until June 24, 2024, at which point it will default to 90 days.</para>
	/// <para>If Transactions has already been added to the Item prior to this call, this field will have no effect.</para>
	/// <para>We strongly recommend that customers utilizing <a href="https://plaid.com/docs/api/products/transactions/#transactionsrecurringget">Recurring Transactions</a> request at least 180 days of history for optimal results.</para>
	/// </summary>
	[JsonPropertyName("days_requested")]
	public int? DaysRequested { get; set; } = default!;
}