namespace Going.Plaid.Entity;

/// <summary>
/// 
/// </summary>
public record HealthIncident
{
	/// <summary>
	/// <para>The start date of the incident, in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format, e.g. <c>"2020-10-30T15:26:48Z"</c>.</para>
	/// </summary>
	[JsonPropertyName("start_date")]
	public DateTimeOffset StartDate { get; init; } = default!;

	/// <summary>
	/// <para>The end date of the incident, in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format, e.g. <c>"2020-10-30T15:26:48Z"</c>.</para>
	/// </summary>
	[JsonPropertyName("end_date")]
	public DateTimeOffset EndDate { get; init; } = default!;

	/// <summary>
	/// <para>The title of the incident</para>
	/// </summary>
	[JsonPropertyName("title")]
	public string Title { get; init; } = default!;

	/// <summary>
	/// <para>Updates on the health incident.</para>
	/// </summary>
	[JsonPropertyName("incident_updates")]
	public IReadOnlyList<Entity.IncidentUpdate> IncidentUpdates { get; init; } = default!;
}