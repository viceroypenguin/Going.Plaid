namespace Going.Plaid.Entity;

/// <summary>
/// <para>A transaction on the Base Report</para>
/// </summary>
public record BaseReportTransaction
{
	/// <summary>
	/// <para>The settled value of the transaction, denominated in the transaction's currency, as stated in <c>iso_currency_code</c> or <c>unofficial_currency_code</c>. Positive values when money moves out of the account; negative values when money moves in. For example, debit card purchases are positive; credit card payments, direct deposits, and refunds are negative.</para>
	/// </summary>
	[JsonPropertyName("amount")]
	public decimal Amount { get; init; } = default!;

	/// <summary>
	/// <para>The ISO-4217 currency code of the transaction. Always <c>null</c> if <c>unofficial_currency_code</c> is non-null.</para>
	/// </summary>
	[JsonPropertyName("iso_currency_code")]
	public string? IsoCurrencyCode { get; init; } = default!;

	/// <summary>
	/// <para>The unofficial currency code associated with the transaction. Always <c>null</c> if <c>iso_currency_code</c> is non-<c>null</c>. Unofficial currency codes are used for currencies that do not have official ISO currency codes, such as cryptocurrencies and the currencies of certain countries.</para>
	/// <para>See the <a href="https://plaid.com/docs/api/accounts#currency-code-schema">currency code schema</a> for a full listing of supported <c>unofficial_currency_code</c>s.</para>
	/// </summary>
	[JsonPropertyName("unofficial_currency_code")]
	public string? UnofficialCurrencyCode { get; init; } = default!;

	/// <summary>
	/// <para>The string returned by the financial institution to describe the transaction.</para>
	/// </summary>
	[JsonPropertyName("original_description")]
	public string? OriginalDescription { get; init; } = default!;

	/// <summary>
	/// <para>Information describing the intent of the transaction. Most relevant for credit use cases, but not limited to such use cases.</para>
	/// <para>See the <a href="https://plaid.com/documents/credit-category-taxonomy.csv"><c>taxonomy csv file</c></a> for a full list of credit categories.</para>
	/// </summary>
	[JsonPropertyName("credit_category")]
	public Entity.CreditCategory? CreditCategory { get; init; } = default!;

	/// <summary>
	/// <para>The check number of the transaction. This field is only populated for check transactions.</para>
	/// </summary>
	[JsonPropertyName("check_number")]
	public string? CheckNumber { get; init; } = default!;

	/// <summary>
	/// <para>For pending transactions, the date that the transaction occurred; for posted transactions, the date that the transaction posted. Both dates are returned in an <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format ( <c>YYYY-MM-DD</c> ).</para>
	/// </summary>
	[JsonPropertyName("date")]
	public DateOnly Date { get; init; } = default!;

	/// <summary>
	/// <para>The date on which the transaction took place, in IS0 8601 format.</para>
	/// </summary>
	[JsonPropertyName("date_transacted")]
	public string? DateTransacted { get; init; } = default!;

	/// <summary>
	/// <para>A representation of where a transaction took place</para>
	/// </summary>
	[JsonPropertyName("location")]
	public Entity.Location? Location { get; init; } = default!;

	/// <summary>
	/// <para>The merchant name, as enriched by Plaid from the <c>name</c> field. This is typically a more human-readable version of the merchant counterparty in the transaction. For some bank transactions (such as checks or account transfers) where there is no meaningful merchant name, this value will be <c>null</c>.</para>
	/// </summary>
	[JsonPropertyName("merchant_name")]
	public string? MerchantName { get; init; } = default!;

	/// <summary>
	/// <para>When <c>true</c>, identifies the transaction as pending or unsettled. Pending transaction details (name, type, amount, category ID) may change before they are settled.</para>
	/// </summary>
	[JsonPropertyName("pending")]
	public bool Pending { get; init; } = default!;

	/// <summary>
	/// <para>The name of the account owner. This field is not typically populated and only relevant when dealing with sub-accounts.</para>
	/// </summary>
	[JsonPropertyName("account_owner")]
	public string? AccountOwner { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("transaction_type")]
	public Entity.BaseReportTransactionType? TransactionType { get; init; } = default!;

	/// <summary>
	/// <para>A hierarchical array of the categories to which this transaction belongs. For a full list of categories, see <a href="https://plaid.com/docs/api/products/transactions/#categoriesget"><c>/categories/get</c></a>.</para>
	/// </summary>
	[JsonPropertyName("category")]
	public IReadOnlyList<string>? Category { get; init; } = default!;

	/// <summary>
	/// <para>The ID of the category to which this transaction belongs. For a full list of categories, see <a href="https://plaid.com/docs/api/products/transactions/#categoriesget"><c>/categories/get</c></a>.</para>
	/// </summary>
	[JsonPropertyName("category_id")]
	public Entity.BaseReportTransactionCategoryIdObject? CategoryId { get; init; } = default!;

}
