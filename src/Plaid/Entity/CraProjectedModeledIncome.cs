namespace Going.Plaid.Entity;

/// <summary>
/// <para>Forward-looking modeled estimate of income based on recent income transactions and trends in active streams.</para>
/// </summary>
public record CraProjectedModeledIncome
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
