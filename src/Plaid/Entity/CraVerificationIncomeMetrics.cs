namespace Going.Plaid.Entity;

/// <summary>
/// <para>Modeled income metrics for a given income stream or user summary.</para>
/// </summary>
public record CraVerificationIncomeMetrics
{
	/// <summary>
	/// <para>Modeled estimate of current income based on recently observed income transactions.</para>
	/// </summary>
	[JsonPropertyName("current")]
	public Entity.CraVerificationModeledIncome? Current { get; init; } = default!;

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
