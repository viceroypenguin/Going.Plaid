namespace Going.Plaid.Entity;

/// <summary>
/// <para>Edit counts over various time periods.</para>
/// </summary>
public record UserAccountIdentityEditCounts
{
	/// <summary>
	/// <para>Number of edits in the current session</para>
	/// </summary>
	[JsonPropertyName("edits_current")]
	public int? EditsCurrent { get; init; } = default!;

	/// <summary>
	/// <para>Number of edits in the last 1 day</para>
	/// </summary>
	[JsonPropertyName("edits_1d")]
	public int? Edits1d { get; init; } = default!;

	/// <summary>
	/// <para>Number of edits in the last 30 days</para>
	/// </summary>
	[JsonPropertyName("edits_30d")]
	public int? Edits30d { get; init; } = default!;

	/// <summary>
	/// <para>Number of edits in the last 365 days</para>
	/// </summary>
	[JsonPropertyName("edits_365d")]
	public int? Edits365d { get; init; } = default!;

	/// <summary>
	/// <para>Total number of edits</para>
	/// </summary>
	[JsonPropertyName("edits_all_time")]
	public int? EditsAllTime { get; init; } = default!;

}
