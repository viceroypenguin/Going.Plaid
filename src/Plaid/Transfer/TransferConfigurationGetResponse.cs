namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the response schema for <c>/transfer/configuration/get</c></para>
/// </summary>
public record TransferConfigurationGetResponse : ResponseBase
{
	/// <summary>
	/// <para>The max limit of dollar amount of a single transfer (decimal string with two digits of precision e.g. "10.00").</para>
	/// </summary>
	[JsonPropertyName("max_single_transfer_amount")]
	[Obsolete]
	public string MaxSingleTransferAmount { get; init; } = default!;

	/// <summary>
	/// <para>The max limit of dollar amount of a single credit transfer (decimal string with two digits of precision e.g. "10.00").</para>
	/// </summary>
	[JsonPropertyName("max_single_transfer_credit_amount")]
	public string MaxSingleTransferCreditAmount { get; init; } = default!;

	/// <summary>
	/// <para>The max limit of dollar amount of a single debit transfer (decimal string with two digits of precision e.g. "10.00").</para>
	/// </summary>
	[JsonPropertyName("max_single_transfer_debit_amount")]
	public string MaxSingleTransferDebitAmount { get; init; } = default!;

	/// <summary>
	/// <para>The max limit of sum of dollar amount of credit transfers in last 24 hours (decimal string with two digits of precision e.g. "10.00").</para>
	/// </summary>
	[JsonPropertyName("max_daily_credit_amount")]
	public string MaxDailyCreditAmount { get; init; } = default!;

	/// <summary>
	/// <para>The max limit of sum of dollar amount of debit transfers in last 24 hours (decimal string with two digits of precision e.g. "10.00").</para>
	/// </summary>
	[JsonPropertyName("max_daily_debit_amount")]
	public string MaxDailyDebitAmount { get; init; } = default!;

	/// <summary>
	/// <para>The max limit of sum of dollar amount of credit and debit transfers in one calendar month (decimal string with two digits of precision e.g. "10.00").</para>
	/// </summary>
	[JsonPropertyName("max_monthly_amount")]
	[Obsolete]
	public string MaxMonthlyAmount { get; init; } = default!;

	/// <summary>
	/// <para>The max limit of sum of dollar amount of credit transfers in one calendar month (decimal string with two digits of precision e.g. "10.00").</para>
	/// </summary>
	[JsonPropertyName("max_monthly_credit_amount")]
	public string MaxMonthlyCreditAmount { get; init; } = default!;

	/// <summary>
	/// <para>The max limit of sum of dollar amount of debit transfers in one calendar month (decimal string with two digits of precision e.g. "10.00").</para>
	/// </summary>
	[JsonPropertyName("max_monthly_debit_amount")]
	public string MaxMonthlyDebitAmount { get; init; } = default!;

	/// <summary>
	/// <para>The currency of the dollar amount, e.g. "USD".</para>
	/// </summary>
	[JsonPropertyName("iso_currency_code")]
	public string IsoCurrencyCode { get; init; } = default!;

}
