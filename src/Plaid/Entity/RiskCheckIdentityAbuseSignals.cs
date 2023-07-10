namespace Going.Plaid.Entity;

/// <summary>
/// <para>Result summary object capturing abuse signals related to <c>identity abuse</c>, e.g. stolen and synthetic identity fraud.</para>
/// </summary>
public record RiskCheckIdentityAbuseSignals
{
	/// <summary>
	/// <para>Field containing the data used in determining the outcome of the synthetic identity risk check.</para>
	/// <para>Contains the following fields:</para>
	/// <para><c>score</c> - A score from 0 to 100 indicating the likelihood that the user is a synthetic identity.</para>
	/// </summary>
	[JsonPropertyName("synthetic_identity")]
	public Entity.RiskCheckSyntheticIdentity? SyntheticIdentity { get; init; } = default!;

	/// <summary>
	/// <para>Field containing the data used in determining the outcome of the stolen identity risk check.</para>
	/// <para>Contains the following fields:</para>
	/// <para><c>score</c> - A score from 0 to 100 indicating the likelihood that the user is a stolen identity.</para>
	/// </summary>
	[JsonPropertyName("stolen_identity")]
	public Entity.RiskCheckStolenIdentity? StolenIdentity { get; init; } = default!;
}