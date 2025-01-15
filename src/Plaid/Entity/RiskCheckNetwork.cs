namespace Going.Plaid.Entity;

/// <summary>
/// <para>Result summary object specifying values for network attributes of risk check.</para>
/// </summary>
public record RiskCheckNetwork
{
	/// <summary>
	/// <para>Risk level for the given risk check type.</para>
	/// </summary>
	[JsonPropertyName("risk_level")]
	public Entity.RiskLevel RiskLevel { get; init; } = default!;

	/// <summary>
	/// <para>List of factors, when available, that contribute towards the risk level of the given risk check type.</para>
	/// </summary>
	[JsonPropertyName("factors")]
	public IReadOnlyList<string> Factors { get; init; } = default!;

}
