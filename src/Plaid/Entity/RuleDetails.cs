namespace Going.Plaid.Entity;

/// <summary>
/// <para>Details about the rule that was triggered for this transaction.</para>
/// </summary>
public record RuleDetails
{
	/// <summary>
	/// <para>The result of the rule that was triggered for this transaction.</para>
	/// </summary>
	[JsonPropertyName("result")]
	public Entity.RuleResult Result { get; init; } = default!;

	/// <summary>
	/// <para>A message for your internal use about the rule that was triggered for this transaction.</para>
	/// </summary>
	[JsonPropertyName("internal_note")]
	public string? InternalNote { get; init; } = default!;

	/// <summary>
	/// <para>A string key used to trigger programmatic behavior for a certain <c>result</c>. For instance, you could optionally choose to define a <c>3-day-hold</c> key for an <c>ACCEPT</c> result.</para>
	/// </summary>
	[JsonPropertyName("custom_action_key")]
	public string? CustomActionKey { get; init; } = default!;

}
