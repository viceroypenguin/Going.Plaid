namespace Going.Plaid.Entity;

/// <summary>
/// <para>Modeled estimate of current income based on recently observed income transactions.</para>
/// </summary>
public record CraCurrentModeledIncome
{
	/// <summary>
	/// <para>Modeled estimate of the monthly income.</para>
	/// </summary>
	[JsonPropertyName("monthly")]
	public Entity.CraMonthlyIncomeValues Monthly { get; init; } = default!;

	/// <summary>
	/// <para>Modeled estimate of the annual income.</para>
	/// </summary>
	[JsonPropertyName("annual")]
	public Entity.CraAnnualIncomeValues Annual { get; init; } = default!;

}
