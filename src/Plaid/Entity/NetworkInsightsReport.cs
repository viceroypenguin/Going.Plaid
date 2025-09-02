namespace Going.Plaid.Entity;

/// <summary>
/// <para>Contains data for the Network Insights Report.</para>
/// </summary>
public record NetworkInsightsReport
{
	/// <summary>
	/// <para>The unique identifier associated with the Network Insights report object.</para>
	/// </summary>
	[JsonPropertyName("report_id")]
	public string ReportId { get; init; } = default!;

	/// <summary>
	/// <para>The time when the Network Insights Report was generated.</para>
	/// </summary>
	[JsonPropertyName("generated_time")]
	public DateTimeOffset GeneratedTime { get; init; } = default!;

	/// <summary>
	/// <para>A map of network attributes, where the key is a string, and the value is a float, int, or boolean.</para>
	/// </summary>
	[JsonPropertyName("network_attributes")]
	public Entity.NetworkInsights NetworkAttributes { get; init; } = default!;

	/// <summary>
	/// <para>A list of Items associated with the provided <c>access_tokens</c>.</para>
	/// </summary>
	[JsonPropertyName("items")]
	public IReadOnlyList<Entity.NetworkInsightsItem> Items { get; init; } = default!;

}
