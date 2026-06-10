namespace Going.Plaid.Entity;

/// <summary>
/// <para>Modeled estimate of current income based on recently observed income transactions.</para>
/// </summary>
public record CraVerificationModeledIncome
{
	/// <summary>
	/// <para>Modeled income values for a given time period.</para>
	/// </summary>
	[JsonPropertyName("monthly")]
	public Entity.CraVerificationIncomeValues Monthly { get; init; } = default!;

	/// <summary>
	/// <para>Modeled income values for a given time period.</para>
	/// </summary>
	[JsonPropertyName("annual")]
	public Entity.CraVerificationIncomeValues Annual { get; init; } = default!;

}
