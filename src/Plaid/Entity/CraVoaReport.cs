namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object representing a VOE report.</para>
/// </summary>
public record CraVoaReport
{
	/// <summary>
	/// <para>The date and time when the VOA Report was created, in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format (e.g. "2018-04-12T03:32:11Z").</para>
	/// </summary>
	[JsonPropertyName("generated_time")]
	public DateTimeOffset GeneratedTime { get; init; } = default!;

	/// <summary>
	/// <para>The number of days of transaction history that the VOA report covers.</para>
	/// </summary>
	[JsonPropertyName("days_requested")]
	public decimal DaysRequested { get; init; } = default!;

	/// <summary>
	/// <para>Data returned by Plaid about each of the Items included in the Base Report.</para>
	/// </summary>
	[JsonPropertyName("items")]
	public IReadOnlyList<Entity.CraVoaReportItem> Items { get; init; } = default!;

	/// <summary>
	/// <para>Attributes for the VOA report.</para>
	/// </summary>
	[JsonPropertyName("attributes")]
	public Entity.CraVoaReportAttributes Attributes { get; init; } = default!;

}
