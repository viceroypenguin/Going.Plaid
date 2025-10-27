namespace Going.Plaid.Entity;

/// <summary>
/// <para>Details about the transaction result after evaluation by the requested Ruleset. If a <c>ruleset_key</c> is not provided, for customers who began using Signal Transaction Scores before October 15, 2025, by default, this field will be omitted. To learn more, see <a href="https://plaid.com/docs/signal/signal-rules/">Signal Rules</a>.</para>
/// </summary>
public record SignalEvaluateRuleset
{
	/// <summary>
	/// <para>The key of the Ruleset used for this transaction.</para>
	/// </summary>
	[JsonPropertyName("ruleset_key")]
	public string? RulesetKey { get; init; } = default!;

	/// <summary>
	/// <para>The result of the rule that was triggered for this transaction.</para>
	/// </summary>
	[JsonPropertyName("result")]
	public Entity.RuleResult Result { get; init; } = default!;

	/// <summary>
	/// <para>Rules are run in numerical order. The first rule with a logic match is triggered. These are the details of that rule.</para>
	/// </summary>
	[JsonPropertyName("triggered_rule_details")]
	public Entity.RuleDetails? TriggeredRuleDetails { get; init; } = default!;

	/// <summary>
	/// <para>The evaluated outcome for this transaction. This field is deprecated, use <c>result</c> or <c>triggered_rule_details.custom_action_key</c> instead.</para>
	/// </summary>
	[JsonPropertyName("outcome")]
	[Obsolete]
	public string? Outcome { get; init; } = default!;

}
