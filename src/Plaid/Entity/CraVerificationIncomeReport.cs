namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object representing an Income Report within the Home Lending Report.</para>
/// </summary>
public record CraVerificationIncomeReport
{
	/// <summary>
	/// <para>The time when the Home Lending Income Report was generated.</para>
	/// </summary>
	[JsonPropertyName("generated_time")]
	public DateTimeOffset GeneratedTime { get; init; } = default!;

	/// <summary>
	/// <para>The number of days requested by the customer for the Home Lending Income Report.</para>
	/// </summary>
	[JsonPropertyName("days_requested")]
	public int DaysRequested { get; init; } = default!;

	/// <summary>
	/// <para>Aggregated summary of all income streams for this user.</para>
	/// </summary>
	[JsonPropertyName("user_summary")]
	public Entity.CraVerificationIncomeUserSummary? UserSummary { get; init; } = default!;

	/// <summary>
	/// <para>The list of income streams for this user.</para>
	/// </summary>
	[JsonPropertyName("income_streams")]
	public IReadOnlyList<Entity.CraVerificationIncomeStream> IncomeStreams { get; init; } = default!;

	/// <summary>
	/// <para>The list of Items in the report along with the associated metadata about the Item.</para>
	/// </summary>
	[JsonPropertyName("items")]
	public IReadOnlyList<Entity.CraVerificationIncomeItem> Items { get; init; } = default!;

}
