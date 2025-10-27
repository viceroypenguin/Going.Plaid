namespace Going.Plaid.Entity;

/// <summary>
/// <para>Detailed expense information for a specific credit category, including transaction count and total amount spent.</para>
/// </summary>
public record CategoryExpenses
{
	/// <summary>
	/// <para>The ID of the credit category.</para>
	/// <para>See the <a href="https://plaid.com/docs/api/products/assets/#asset_report-get-response-report-items-accounts-transactions-credit-category">category taxonomy</a> for a full listing of category IDs.</para>
	/// </summary>
	[JsonPropertyName("id")]
	public string? Id { get; init; } = default!;

	/// <summary>
	/// <para>The total number of transactions that fall into this credit category within the given time window.</para>
	/// </summary>
	[JsonPropertyName("transactions_count")]
	public int? TransactionsCount { get; init; } = default!;

	/// <summary>
	/// <para>The total value for all the transactions that fall into this category within the given time window.</para>
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

	/// <summary>
	/// <para>The monthly average amount calculated by dividing the total by the number of calendar months in the time period.</para>
	/// </summary>
	[JsonPropertyName("monthly_average")]
	public Entity.MonthlyAverage? MonthlyAverage { get; init; } = default!;

}
