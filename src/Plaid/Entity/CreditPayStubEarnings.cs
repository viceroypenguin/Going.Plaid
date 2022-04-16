namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object representing both a breakdown of earnings on a pay stub and the total earnings.</para>
/// </summary>
public record CreditPayStubEarnings
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("breakdown")]
	public IReadOnlyList<Entity.PayStubEarningsBreakdown> Breakdown { get; init; } = default!;

	/// <summary>
	/// <para>An object representing both the current pay period and year to date amount for an earning category.</para>
	/// </summary>
	[JsonPropertyName("total")]
	public Entity.PayStubEarningsTotal Total { get; init; } = default!;
}