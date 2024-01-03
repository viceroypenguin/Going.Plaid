namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object with the deduction information found on a pay stub.</para>
/// </summary>
public record CreditPayStubDeductions
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("breakdown")]
	public IReadOnlyList<Entity.PayStubDeductionsBreakdown> Breakdown { get; init; } = default!;

	/// <summary>
	/// <para>An object representing the total deductions for the pay period</para>
	/// </summary>
	[JsonPropertyName("total")]
	public Entity.PayStubDeductionsTotal Total { get; init; } = default!;

}
