namespace Going.Plaid.Entity;

/// <summary>
/// <para>The end user's monthly summary for the income source(s).</para>
/// </summary>
public record CreditBankIncomeHistoricalSummary
{
	/// <summary>
	/// <para>Total amount of earnings for the income source(s) of the user for the month in the summary.</para>
	/// </summary>
	[JsonPropertyName("total_amount")]
	public decimal TotalAmount { get; init; } = default!;

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
	/// <para>The start date of the period covered in this monthly summary.</para>
	/// <para>This date will be the first day of the month, unless the month being covered is a partial month because it is the first month included in the summary and the date range being requested does not begin with the first day of the month.</para>
	/// <para>The date will be returned in an ISO 8601 format (YYYY-MM-DD).</para>
	/// </summary>
	[JsonPropertyName("start_date")]
	public DateOnly StartDate { get; init; } = default!;

	/// <summary>
	/// <para>The end date of the period included in this monthly summary.</para>
	/// <para>This date will be the last day of the month, unless the month being covered is a partial month because it is the last month included in the summary and the date range being requested does not end with the last day of the month.</para>
	/// <para>The date will be returned in an ISO 8601 format (YYYY-MM-DD).</para>
	/// </summary>
	[JsonPropertyName("end_date")]
	public DateOnly EndDate { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("transactions")]
	public IReadOnlyList<Entity.CreditBankIncomeTransaction> Transactions { get; init; } = default!;
}