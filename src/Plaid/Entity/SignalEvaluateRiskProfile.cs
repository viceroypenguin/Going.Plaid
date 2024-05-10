namespace Going.Plaid.Entity;

/// <summary>
/// <para>Details about the transaction result after evaluated by the requested risk profile. If a <c>risk_profile_key</c> is not provided, this field will be omitted. This feature is currently in closed beta; to request access, contact your account manager.</para>
/// </summary>
public record SignalEvaluateRiskProfile
{
	/// <summary>
	/// <para>The key of the risk profile used for this transaction.</para>
	/// </summary>
	[JsonPropertyName("key")]
	public string? Key { get; init; } = default!;

	/// <summary>
	/// <para>The evaluated outcome for this transaction. You can configure a list of outcomes, such as "accept", "review", and "decline" using the Signal dashboard located within the Plaid Dashboard.</para>
	/// </summary>
	[JsonPropertyName("outcome")]
	public string? Outcome { get; init; } = default!;

}
