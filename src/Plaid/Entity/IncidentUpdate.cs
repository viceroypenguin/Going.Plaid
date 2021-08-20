namespace Going.Plaid.Entity;

/// <summary>
/// 
/// </summary>
public record IncidentUpdate
{
	/// <summary>
	/// <para>The content of the update.</para>
	/// </summary>
	[JsonPropertyName("description")]
	public string Description { get; init; } = default!;

	/// <summary>
	/// <para>The status of the incident.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.IncidentUpdateStatusEnum Status { get; init; } = default!;

	/// <summary>
	/// <para>The date when the update was published, in ISO 8601 format, e.g. <c>"2020-10-30T15:26:48Z"</c>.</para>
	/// </summary>
	[JsonPropertyName("updated_date")]
	public DateTimeOffset UpdatedDate { get; init; } = default!;
}