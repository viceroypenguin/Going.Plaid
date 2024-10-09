namespace Going.Plaid.Entity;

/// <summary>
/// <para>Detailed information for the income source.</para>
/// </summary>
public record CreditBankIncomeSource
{
	/// <summary>
	/// <para>A unique identifier for an income source.</para>
	/// </summary>
	[JsonPropertyName("income_source_id")]
	public string? IncomeSourceId { get; init; } = default!;

	/// <summary>
	/// <para>The most common name or original description for the underlying income transactions.</para>
	/// </summary>
	[JsonPropertyName("income_description")]
	public string? IncomeDescription { get; init; } = default!;

	/// <summary>
	/// <para>The income category.</para>
	/// </summary>
	[JsonPropertyName("income_category")]
	public Entity.CreditBankIncomeCategory? IncomeCategory { get; init; } = default!;

	/// <summary>
	/// <para>Plaid's unique identifier for the account.</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string? AccountId { get; init; } = default!;

	/// <summary>
	/// <para>Minimum of all dates within the specific income sources in the user's bank account for days requested by the client.</para>
	/// <para>The date will be returned in an ISO 8601 format (YYYY-MM-DD).</para>
	/// </summary>
	[JsonPropertyName("start_date")]
	public DateOnly? StartDate { get; init; } = default!;

	/// <summary>
	/// <para>Maximum of all dates within the specific income sources in the user’s bank account for days requested by the client.</para>
	/// <para>The date will be returned in an ISO 8601 format (YYYY-MM-DD).</para>
	/// </summary>
	[JsonPropertyName("end_date")]
	public DateOnly? EndDate { get; init; } = default!;

	/// <summary>
	/// <para>The income pay frequency.</para>
	/// </summary>
	[JsonPropertyName("pay_frequency")]
	public Entity.CreditBankIncomePayFrequency? PayFrequency { get; init; } = default!;

	/// <summary>
	/// <para>Total amount of earnings in the user’s bank account for the specific income source for days requested by the client.</para>
	/// </summary>
	[JsonPropertyName("total_amount")]
	public decimal? TotalAmount { get; init; } = default!;

	/// <summary>
	/// <para>Number of transactions for the income source within the start and end date.</para>
	/// </summary>
	[JsonPropertyName("transaction_count")]
	public int? TransactionCount { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("historical_summary")]
	public IReadOnlyList<Entity.CreditBankIncomeHistoricalSummary>? HistoricalSummary { get; init; } = default!;

}
