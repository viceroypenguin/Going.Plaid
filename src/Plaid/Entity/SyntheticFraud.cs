namespace Going.Plaid.Entity;

/// <summary>
/// <para>Field containing the data used in determining the outcome of a synthetic fraud risk check.</para>
/// </summary>
public record SyntheticFraud
{
	/// <summary>
	/// <para>Risk level for the given risk check type.</para>
	/// </summary>
	[JsonPropertyName("risk_level")]
	public Entity.RiskLevel RiskLevel { get; init; } = default!;

}
