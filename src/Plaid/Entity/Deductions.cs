namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object with the deduction information found on a paystub.</para>
/// </summary>
public record Deductions
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("subtotals")]
	public IReadOnlyList<Entity.Total>? Subtotals { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("breakdown")]
	public IReadOnlyList<Entity.DeductionsBreakdown> Breakdown { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("totals")]
	public IReadOnlyList<Entity.Total>? Totals { get; init; } = default!;

	/// <summary>
	/// <para>An object representing the total deductions for the pay period</para>
	/// </summary>
	[JsonPropertyName("total")]
	public Entity.DeductionsTotal Total { get; init; } = default!;
}