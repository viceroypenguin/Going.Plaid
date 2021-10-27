namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object representing a balance held by an account in the past</para>
/// </summary>
public record HistoricalBalance
{
	/// <summary>
	/// <para>The date of the calculated historical balance, in an <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format (YYYY-MM-DD)</para>
	/// </summary>
	[JsonPropertyName("date")]
	public DateOnly Date { get; init; } = default!;

	/// <summary>
	/// <para>The total amount of funds in the account, calculated from the <c>current</c> balance in the <c>balance</c> object by subtracting inflows and adding back outflows according to the posted date of each transaction.</para>
	/// <para>If the account has any pending transactions, historical balance amounts on or after the date of the earliest pending transaction may differ if retrieved in subsequent Asset Reports as a result of those pending transactions posting.</para>
	/// </summary>
	[JsonPropertyName("current")]
	public decimal Current { get; init; } = default!;

	/// <summary>
	/// <para>The ISO-4217 currency code of the balance. Always <c>null</c> if <c>unofficial_currency_code</c> is non-<c>null</c>.</para>
	/// </summary>
	[JsonPropertyName("iso_currency_code")]
	public string? IsoCurrencyCode { get; init; } = default!;

	/// <summary>
	/// <para>The unofficial currency code associated with the balance. Always <c>null</c> if <c>iso_currency_code</c> is non-<c>null</c>.</para>
	/// <para>See the <a href="https://plaid.com/docs/api/accounts#currency-code-schema">currency code schema</a> for a full listing of supported <c>iso_currency_code</c>s.</para>
	/// </summary>
	[JsonPropertyName("unofficial_currency_code")]
	public string? UnofficialCurrencyCode { get; init; } = default!;
}