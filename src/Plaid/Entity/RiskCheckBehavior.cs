namespace Going.Plaid.Entity;

/// <summary>
/// <para>Result summary object specifying values for <c>behavior</c> attributes of risk check, when available.</para>
/// </summary>
public record RiskCheckBehavior
{
	/// <summary>
	/// <para>Field describing the overall user interaction signals of a behavior risk check. This value represents how familiar the user is with the personal data they provide, based on a number of signals that are collected during their session.</para>
	/// </summary>
	[JsonPropertyName("user_interactions")]
	public Entity.RiskCheckBehaviorUserInteractionsLabel UserInteractions { get; init; } = default!;

	/// <summary>
	/// <para>Field describing the outcome of a fraud ring behavior risk check.</para>
	/// </summary>
	[JsonPropertyName("fraud_ring_detected")]
	public Entity.RiskCheckBehaviorFraudRingDetectedLabel FraudRingDetected { get; init; } = default!;

	/// <summary>
	/// <para>Field describing the outcome of a bot detection behavior risk check.</para>
	/// </summary>
	[JsonPropertyName("bot_detected")]
	public Entity.RiskCheckBehaviorBotDetectedLabel BotDetected { get; init; } = default!;

}
