namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object containing metadata about the provided transactions.</para>
/// </summary>
public record PrismCashScoreMetadata
{
	/// <summary>
	/// <para>Number of days since the oldest transaction.</para>
	/// </summary>
	[JsonPropertyName("max_age")]
	public int? MaxAge { get; init; } = default!;

	/// <summary>
	/// <para>Number of days since the latest transaction.</para>
	/// </summary>
	[JsonPropertyName("min_age")]
	public int? MinAge { get; init; } = default!;

	/// <summary>
	/// <para>Number of days since the latest credit transaction.</para>
	/// </summary>
	[JsonPropertyName("min_age_credit")]
	public int? MinAgeCredit { get; init; } = default!;

	/// <summary>
	/// <para>Number of days since the latest debit transaction.</para>
	/// </summary>
	[JsonPropertyName("min_age_debit")]
	public int? MinAgeDebit { get; init; } = default!;

	/// <summary>
	/// <para>Number of days since the oldest debit transaction.</para>
	/// </summary>
	[JsonPropertyName("max_age_debit")]
	public int? MaxAgeDebit { get; init; } = default!;

	/// <summary>
	/// <para>Number of days since the oldest credit transaction.</para>
	/// </summary>
	[JsonPropertyName("max_age_credit")]
	public int? MaxAgeCredit { get; init; } = default!;

	/// <summary>
	/// <para>Number of credit transactions.</para>
	/// </summary>
	[JsonPropertyName("num_trxn_credit")]
	public int? NumTrxnCredit { get; init; } = default!;

	/// <summary>
	/// <para>Number of debit transactions.</para>
	/// </summary>
	[JsonPropertyName("num_trxn_debit")]
	public int? NumTrxnDebit { get; init; } = default!;

	/// <summary>
	/// <para>Number of credit transactions in the last 30 days.</para>
	/// </summary>
	[JsonPropertyName("l1m_credit_value_cnt")]
	public int? L1mCreditValueCnt { get; init; } = default!;

	/// <summary>
	/// <para>Number of debit transactions in the last 30 days.</para>
	/// </summary>
	[JsonPropertyName("l1m_debit_value_cnt")]
	public int? L1mDebitValueCnt { get; init; } = default!;

}
