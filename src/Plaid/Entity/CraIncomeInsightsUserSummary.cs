namespace Going.Plaid.Entity;

/// <summary>
/// <para>Aggregated summary of all income streams for this user.</para>
/// </summary>
public record CraIncomeInsightsUserSummary
{
	/// <summary>
	/// <para>List of a user's aggregated income metrics for each currency.</para>
	/// </summary>
	[JsonPropertyName("income_metrics")]
	public IReadOnlyList<Entity.CraIncomeMetrics> IncomeMetrics { get; init; } = default!;

}
