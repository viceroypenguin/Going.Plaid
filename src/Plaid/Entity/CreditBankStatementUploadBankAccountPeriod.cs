namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object containing data on the overall period of the statement.</para>
/// </summary>
public record CreditBankStatementUploadBankAccountPeriod
{
	/// <summary>
	/// <para>The start date of the statement period in ISO 8601 format (YYYY-MM-DD).</para>
	/// </summary>
	[JsonPropertyName("start_date")]
	public DateOnly? StartDate { get; init; } = default!;

	/// <summary>
	/// <para>The end date of the statement period in ISO 8601 format (YYYY-MM-DD).</para>
	/// </summary>
	[JsonPropertyName("end_date")]
	public DateOnly? EndDate { get; init; } = default!;

	/// <summary>
	/// <para>The starting balance of the bank account for the period.</para>
	/// </summary>
	[JsonPropertyName("starting_balance")]
	public decimal? StartingBalance { get; init; } = default!;

	/// <summary>
	/// <para>The ending balance of the bank account for the period.</para>
	/// </summary>
	[JsonPropertyName("ending_balance")]
	public decimal? EndingBalance { get; init; } = default!;
}