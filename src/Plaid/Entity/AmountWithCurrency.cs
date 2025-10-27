namespace Going.Plaid.Entity;

/// <summary>
/// <para>A monetary amount with its associated currency information, supporting both official and unofficial currency codes.</para>
/// </summary>
public record AmountWithCurrency
{
	/// <summary>
	/// <para>The value of the aggregated transactions for this particular transactions group.</para>
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
