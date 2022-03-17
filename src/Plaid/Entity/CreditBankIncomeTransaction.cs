namespace Going.Plaid.Entity;

/// <summary>
/// <para>The transactions data for the end user's income source(s).</para>
/// </summary>
public record CreditBankIncomeTransaction
{
	/// <summary>
	/// <para>The settled value of the transaction, denominated in the account's currency as stated in <c>iso_currency_code</c> or <c>unofficial_currency_code</c>.</para>
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
	/// <para>The merchant name or transaction description.</para>
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; init; } = default!;

	/// <summary>
	/// <para>The string returned by the financial institution to describe the transaction.</para>
	/// </summary>
	[JsonPropertyName("original_description")]
	public string? OriginalDescription { get; init; } = default!;

	/// <summary>
	/// <para>When true, identifies the transaction as pending or unsettled.</para>
	/// <para>Pending transaction details (name, type, amount, category ID) may change before they are settled.</para>
	/// </summary>
	[JsonPropertyName("pending")]
	public bool Pending { get; init; } = default!;

	/// <summary>
	/// <para>The unique ID of the transaction. Like all Plaid identifiers, the <c>transaction_id</c> is case sensitive.</para>
	/// </summary>
	[JsonPropertyName("transaction_id")]
	public string TransactionId { get; init; } = default!;

	/// <summary>
	/// <para>The check number of the transaction. This field is only populated for check transactions.</para>
	/// </summary>
	[JsonPropertyName("check_number")]
	public string? CheckNumber { get; init; } = default!;

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
}