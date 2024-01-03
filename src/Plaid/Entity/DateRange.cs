namespace Going.Plaid.Entity;

/// <summary>
/// <para>A date range with a start and end date</para>
/// </summary>
public record DateRange
{
	/// <summary>
	/// <para>A date in the format YYYY-MM-DD (RFC 3339 Section 5.6).</para>
	/// </summary>
	[JsonPropertyName("beginning")]
	public DateOnly Beginning { get; init; } = default!;

	/// <summary>
	/// <para>A date in the format YYYY-MM-DD (RFC 3339 Section 5.6).</para>
	/// </summary>
	[JsonPropertyName("ending")]
	public DateOnly Ending { get; init; } = default!;

}
