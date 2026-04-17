namespace Going.Plaid.Entity;

/// <summary>
/// <para>An income stream detected for the user.</para>
/// </summary>
public record CraIncomeStream
{
	/// <summary>
	/// <para>A unique identifier for an income stream. If the report is regenerated and a new <c>report_id</c> is created, the new report will have a new set of <c>income_stream_id</c>s.</para>
	/// </summary>
	[JsonPropertyName("income_stream_id")]
	public string IncomeStreamId { get; init; } = default!;

	/// <summary>
	/// <para>Minimum of all dates within the specific income stream for days requested by the client. The date will be returned in an ISO 8601 format (YYYY-MM-DD).</para>
	/// </summary>
	[JsonPropertyName("start_date")]
	public DateOnly StartDate { get; init; } = default!;

	/// <summary>
	/// <para>Maximum of all dates within the specific income stream for days requested by the client. The date will be returned in an ISO 8601 format (YYYY-MM-DD).</para>
	/// </summary>
	[JsonPropertyName("end_date")]
	public DateOnly EndDate { get; init; } = default!;

	/// <summary>
	/// <para>The most common name or original description for the underlying income transactions.</para>
	/// </summary>
	[JsonPropertyName("description")]
	public string Description { get; init; } = default!;

	/// <summary>
	/// <para>Modeled insights for a given income stream.</para>
	/// </summary>
	[JsonPropertyName("insights")]
	public Entity.CraIncomeStreamInsights Insights { get; init; } = default!;

	/// <summary>
	/// <para>Modeled income metrics for a given income stream or user summary.</para>
	/// </summary>
	[JsonPropertyName("income_metrics")]
	public Entity.CraIncomeMetrics IncomeMetrics { get; init; } = default!;

	/// <summary>
	/// <para>The transactions data for the income stream ordered by ascending date.</para>
	/// </summary>
	[JsonPropertyName("transactions")]
	public IReadOnlyList<Entity.CraIncomeTransaction> Transactions { get; init; } = default!;

}
