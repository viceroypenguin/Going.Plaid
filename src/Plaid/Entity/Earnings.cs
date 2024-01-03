namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object representing both a breakdown of earnings on a paystub and the total earnings.</para>
/// </summary>
public record Earnings
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("subtotals")]
	public IReadOnlyList<Entity.EarningsTotal>? Subtotals { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("totals")]
	public IReadOnlyList<Entity.EarningsTotal>? Totals { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("breakdown")]
	public IReadOnlyList<Entity.EarningsBreakdown>? Breakdown { get; init; } = default!;

	/// <summary>
	/// <para>An object representing both the current pay period and year to date amount for an earning category.</para>
	/// </summary>
	[JsonPropertyName("total")]
	public Entity.EarningsTotal? Total { get; init; } = default!;

}
