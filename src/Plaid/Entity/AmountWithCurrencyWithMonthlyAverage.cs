namespace Going.Plaid.Entity;

/// <summary>
/// <para>Represents an amount and a monthly average</para>
/// </summary>
public record AmountWithCurrencyWithMonthlyAverage
{
	/// <summary>
	/// <para>If the parent object represents a category of transactions, such as <c>total_amount</c>, <c>transfers_in</c>, <c>total_income</c>, etc. the <c>amount</c> represents the sum of all of the transactions in the group. </para>
	/// <para>If the parent object is <c>cash_flow</c>, the <c>amount</c> represents the total value of all the inflows minus all the outflows across all the accounts in the report in the given time window. </para>
	/// <para>If the parent object is <c>minimum_balance</c>, the <c>amount</c> represents the lowest balance of the account during the given time window.</para>
	/// </summary>
	[JsonPropertyName("amount")]
	public decimal? Amount { get; init; } = default!;

	/// <summary>
	/// <para>The ISO-4217 currency code of the amount. Always <c>null</c> if <c>unofficial_currency_code</c> is non-<c>null</c>.</para>
	/// </summary>
	[JsonPropertyName("iso_currency_code")]
	public string? IsoCurrencyCode { get; init; } = default!;

	/// <summary>
	/// <para>The unofficial currency code associated with the amount. Always <c>null</c> if <c>iso_currency_code</c> is non-<c>null</c>.</para>
	/// <para>See the <a href="https://plaid.com/docs/api/accounts#currency-code-schema">currency code schema</a> for a full listing of supported <c>unofficial_currency_code</c>s.</para>
	/// </summary>
	[JsonPropertyName("unofficial_currency_code")]
	public string? UnofficialCurrencyCode { get; init; } = default!;

}
