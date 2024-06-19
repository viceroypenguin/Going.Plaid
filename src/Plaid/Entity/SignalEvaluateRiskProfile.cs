namespace Going.Plaid.Entity;

/// <summary>
/// <para>RiskProfile is deprecated, use <c>ruleset</c> instead.</para>
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
