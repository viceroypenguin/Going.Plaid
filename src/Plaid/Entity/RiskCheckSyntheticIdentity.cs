namespace Going.Plaid.Entity;

/// <summary>
/// <para>Field containing the data used in determining the outcome of the synthetic identity risk check.</para>
/// <para>Contains the following fields:</para>
/// <para><c>score</c> - A score from 0 to 100 indicating the likelihood that the user is a synthetic identity.</para>
/// </summary>
public record RiskCheckSyntheticIdentity
{
	/// <summary>
	/// <para>A score from 0 to 100 indicating the likelihood that the user is a synthetic identity.</para>
	/// </summary>
	[JsonPropertyName("score")]
	public int Score { get; init; } = default!;

	/// <summary>
	/// <para>Risk level for the given risk check type.</para>
	/// </summary>
	[JsonPropertyName("risk_level")]
	public Entity.RiskLevel? RiskLevel { get; init; } = default!;

	/// <summary>
	/// <para>Field containing the data used in determining the outcome of a synthetic fraud risk check.</para>
	/// </summary>
	[JsonPropertyName("first_party_synthetic_fraud")]
	public Entity.SyntheticFraud? FirstPartySyntheticFraud { get; init; } = default!;

	/// <summary>
	/// <para>Field containing the data used in determining the outcome of a synthetic fraud risk check.</para>
	/// </summary>
	[JsonPropertyName("third_party_synthetic_fraud")]
	public Entity.SyntheticFraud? ThirdPartySyntheticFraud { get; init; } = default!;

}
