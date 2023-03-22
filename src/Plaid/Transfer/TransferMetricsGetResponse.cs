namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the response schema for <c>/transfer/metrics/get</c></para>
/// </summary>
public record TransferMetricsGetResponse : ResponseBase
{
	/// <summary>
	/// <para>Sum of dollar amount of debit transfers in last 24 hours (decimal string with two digits of precision e.g. "10.00").</para>
	/// </summary>
	[JsonPropertyName("daily_debit_transfer_volume")]
	public string DailyDebitTransferVolume { get; init; } = default!;

	/// <summary>
	/// <para>Sum of dollar amount of credit transfers in last 24 hours (decimal string with two digits of precision e.g. "10.00").</para>
	/// </summary>
	[JsonPropertyName("daily_credit_transfer_volume")]
	public string DailyCreditTransferVolume { get; init; } = default!;

	/// <summary>
	/// <para>Sum of dollar amount of credit and debit transfers in current calendar month (decimal string with two digits of precision e.g. "10.00").</para>
	/// </summary>
	[JsonPropertyName("monthly_transfer_volume")]
	public string MonthlyTransferVolume { get; init; } = default!;

	/// <summary>
	/// <para>The currency of the dollar amount, e.g. "USD".</para>
	/// </summary>
	[JsonPropertyName("iso_currency_code")]
	public string IsoCurrencyCode { get; init; } = default!;
}