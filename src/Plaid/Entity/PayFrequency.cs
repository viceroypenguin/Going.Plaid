namespace Going.Plaid.Entity;

/// <summary>
/// <para>The frequency of the pay period.</para>
/// </summary>
public record PayFrequency
{
	/// <summary>
	/// <para>The frequency of the pay period.</para>
	/// </summary>
	[JsonPropertyName("value")]
	public Entity.PayFrequencyValue Value { get; init; } = default!;

	/// <summary>
	/// <para>The verification status. One of the following:</para>
	/// </summary>
	[JsonPropertyName("verification_status")]
	public Entity.VerificationStatus VerificationStatus { get; init; } = default!;
}