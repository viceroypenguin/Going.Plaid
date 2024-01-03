namespace Going.Plaid.Entity;

/// <summary>
/// <para>An update on the health incident</para>
/// </summary>
public record IncidentUpdate
{
	/// <summary>
	/// <para>The content of the update.</para>
	/// </summary>
	[JsonPropertyName("description")]
	public string? Description { get; init; } = default!;

	/// <summary>
	/// <para>The status of the incident.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.IncidentUpdateStatusEnum? Status { get; init; } = default!;

	/// <summary>
	/// <para>The date when the update was published, in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format, e.g. <c>"2020-10-30T15:26:48Z"</c>.</para>
	/// </summary>
	[JsonPropertyName("updated_date")]
	public DateTimeOffset? UpdatedDate { get; init; } = default!;

}
