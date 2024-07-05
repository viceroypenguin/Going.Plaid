namespace Going.Plaid.Entity;

/// <summary>
/// <para>Contains data for the CRA Network Attributes Report.</para>
/// </summary>
public record CraNetworkAttributesReport
{
	/// <summary>
	/// <para>The unique identifier associated with the Network Attributes report object.</para>
	/// </summary>
	[JsonPropertyName("report_id")]
	public string ReportId { get; init; } = default!;

	/// <summary>
	/// <para>The time when the Network Attributes Report was generated.</para>
	/// </summary>
	[JsonPropertyName("generated_time")]
	public DateTimeOffset GeneratedTime { get; init; } = default!;

	/// <summary>
	/// <para>A map of network attributes, where the key is a string, and the value is a float, int, or boolean.</para>
	/// </summary>
	[JsonPropertyName("network_attributes")]
	public Entity.NetworkAttributes NetworkAttributes { get; init; } = default!;

	/// <summary>
	/// <para>The Items the end user connected in Link.</para>
	/// </summary>
	[JsonPropertyName("items")]
	public IReadOnlyList<Entity.CraNetworkAttributesItem> Items { get; init; } = default!;

}
