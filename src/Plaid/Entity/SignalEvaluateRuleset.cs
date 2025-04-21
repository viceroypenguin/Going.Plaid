namespace Going.Plaid.Entity;

/// <summary>
/// <para>Details about the transaction result after evaluated by the requested Ruleset. If a <c>ruleset_key</c> is not provided, this field will be omitted. This feature is currently in closed beta; to request access, contact your account manager.</para>
/// </summary>
public record SignalEvaluateRuleset
{
	/// <summary>
	/// <para>The key of the Ruleset used for this transaction.</para>
	/// </summary>
	[JsonPropertyName("ruleset_key")]
	public string? RulesetKey { get; init; } = default!;

	/// <summary>
	/// <para>Details about the rule that was triggered for this transaction.</para>
	/// </summary>
	[JsonPropertyName("triggered_rule_details")]
	public Entity.RuleDetails? TriggeredRuleDetails { get; init; } = default!;

	/// <summary>
	/// <para>The evaluated outcome for this transaction. You can configure a list of outcomes, such as "accept", "review", and "decline" using the Signal dashboard located within the Plaid Dashboard.</para>
	/// </summary>
	[JsonPropertyName("outcome")]
	[Obsolete]
	public string? Outcome { get; init; } = default!;

}
