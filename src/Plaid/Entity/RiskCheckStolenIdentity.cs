namespace Going.Plaid.Entity;

/// <summary>
/// <para>Field containing the data used in determining the outcome of the stolen identity risk check.</para>
/// <para>Contains the following fields:</para>
/// <para><c>score</c> - A score from 0 to 100 indicating the likelihood that the user is a stolen identity.</para>
/// </summary>
public record RiskCheckStolenIdentity
{
	/// <summary>
	/// <para>A score from 0 to 100 indicating the likelihood that the user is a stolen identity.</para>
	/// </summary>
	[JsonPropertyName("score")]
	public int Score { get; init; } = default!;
}