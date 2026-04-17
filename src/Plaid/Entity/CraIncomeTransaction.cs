namespace Going.Plaid.Entity;

/// <summary>
/// <para>The transaction data for an income stream.</para>
/// </summary>
public record CraIncomeTransaction
{
	/// <summary>
	/// <para>The unique ID of the transaction. Like all Plaid identifiers, the <c>transaction_id</c> is case sensitive.</para>
	/// </summary>
	[JsonPropertyName("transaction_id")]
	public string TransactionId { get; init; } = default!;

	/// <summary>
	/// <para>The <c>item_id</c> of the Item associated with this webhook, warning, or error</para>
	/// </summary>
	[JsonPropertyName("item_id")]
	public string ItemId { get; init; } = default!;

	/// <summary>
	/// <para>Plaid's unique identifier for the account. This value will not change unless Plaid can't reconcile the account with the data returned by the financial institution. This may occur, for example, when the name of the account changes. If this happens a new <c>account_id</c> will be assigned to the account.</para>
	/// <para>If an account with a specific <c>account_id</c> disappears instead of changing, the account is likely closed. Closed accounts are not returned by the Plaid API.</para>
	/// <para>Like all Plaid identifiers, the <c>account_id</c> is case sensitive.</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string AccountId { get; init; } = default!;

	/// <summary>
	/// <para>The settled value of the transaction, denominated in the transaction's currency as stated in <c>iso_currency_code</c> or <c>unofficial_currency_code</c>.</para>
	/// <para>Positive values when money moves out of the account; negative values when money moves in.</para>
	/// <para>For example, credit card purchases are positive; credit card payment, direct deposits, and refunds are negative.</para>
	/// </summary>
	[JsonPropertyName("amount")]
	public decimal Amount { get; init; } = default!;

	/// <summary>
	/// <para>For pending transactions, the date that the transaction occurred; for posted transactions, the date that the transaction posted.</para>
	/// <para>Both dates are returned in an ISO 8601 format (YYYY-MM-DD).</para>
	/// </summary>
	[JsonPropertyName("date")]
	public DateOnly Date { get; init; } = default!;

	/// <summary>
	/// <para>The string returned by the financial institution to describe the transaction.</para>
	/// </summary>
	[JsonPropertyName("original_description")]
	public string OriginalDescription { get; init; } = default!;

	/// <summary>
	/// <para>The ISO 4217 currency code of the amount or balance.</para>
	/// </summary>
	[JsonPropertyName("iso_currency_code")]
	public string? IsoCurrencyCode { get; init; } = default!;

	/// <summary>
	/// <para>The unofficial currency code associated with the amount or balance. Always <c>null</c> if <c>iso_currency_code</c> is non-null.</para>
	/// <para>Unofficial currency codes are used for currencies that do not have official ISO currency codes, such as cryptocurrencies and the currencies of certain countries.</para>
	/// </summary>
	[JsonPropertyName("unofficial_currency_code")]
	public string? UnofficialCurrencyCode { get; init; } = default!;

	/// <summary>
	/// <para>Metadata on whether this income transaction is an outlier.</para>
	/// </summary>
	[JsonPropertyName("outlier")]
	public Entity.CraIncomeTransactionOutlier Outlier { get; init; } = default!;

}
