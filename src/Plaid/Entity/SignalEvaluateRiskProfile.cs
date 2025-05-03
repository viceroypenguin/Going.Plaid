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
	/// <para>Legacy method of inspecting the result of the ruleset. New integrations should simply use the “result” property instead. This value will be omitted if you do not have a live existing integration with rules using this field.</para>
	/// </summary>
	[JsonPropertyName("outcome")]
	public string? Outcome { get; init; } = default!;

}
