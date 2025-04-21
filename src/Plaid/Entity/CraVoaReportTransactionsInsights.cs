namespace Going.Plaid.Entity;

/// <summary>
/// <para>Transaction data associated with the account.</para>
/// </summary>
public record CraVoaReportTransactionsInsights
{
	/// <summary>
	/// <para>Transaction history associated with the account.</para>
	/// </summary>
	[JsonPropertyName("all_transactions")]
	public IReadOnlyList<Entity.BaseReportTransaction> AllTransactions { get; init; } = default!;

	/// <summary>
	/// <para>The latest timeframe provided by the FI, in an ISO 8601 format (YYYY-MM-DD).</para>
	/// </summary>
	[JsonPropertyName("end_date")]
	public DateOnly? EndDate { get; init; } = default!;

	/// <summary>
	/// <para>The earliest timeframe provided by the FI, in an ISO 8601 format (YYYY-MM-DD).</para>
	/// </summary>
	[JsonPropertyName("start_date")]
	public DateOnly? StartDate { get; init; } = default!;

}
