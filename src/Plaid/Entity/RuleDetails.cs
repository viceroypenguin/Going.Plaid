namespace Going.Plaid.Entity;

/// <summary>
/// <para>Rules are run in numerical order. The first rule with a logic match is triggered. These are the details of that rule.</para>
/// </summary>
public record RuleDetails
{
	/// <summary>
	/// <para>An optional message attached to the triggered rule, defined within the Dashboard, for your internal use. Useful for debugging, such as “Account appears to be closed.”</para>
	/// </summary>
	[JsonPropertyName("internal_note")]
	public string? InternalNote { get; init; } = default!;

	/// <summary>
	/// <para>A string key, defined within the Dashboard, used to trigger programmatic behavior for a certain result. For instance, you could optionally choose to define a "3-day-hold" <c>custom_action_key</c> for an ACCEPT result.</para>
	/// </summary>
	[JsonPropertyName("custom_action_key")]
	public string? CustomActionKey { get; init; } = default!;

}
