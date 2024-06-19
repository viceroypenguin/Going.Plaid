namespace Going.Plaid.Entity;

/// <summary>
/// <para>The Partner Insights report of the bank data for an end user.</para>
/// </summary>
public record CraPartnerInsights
{
	/// <summary>
	/// <para>A unique identifier associated with the Partner Insights object.</para>
	/// </summary>
	[JsonPropertyName("report_id")]
	public string? ReportId { get; init; } = default!;

	/// <summary>
	/// <para>The time when the Partner Insights report was generated.</para>
	/// </summary>
	[JsonPropertyName("generated_time")]
	public DateTimeOffset? GeneratedTime { get; init; } = default!;

	/// <summary>
	/// <para>The Prism Data insights for the user.</para>
	/// </summary>
	[JsonPropertyName("prism")]
	public Entity.CraPartnerInsightsPrism? Prism { get; init; } = default!;

	/// <summary>
	/// <para>The list of Items used in the report along with the associated metadata about the Item.</para>
	/// </summary>
	[JsonPropertyName("items")]
	public IReadOnlyList<Entity.CraPartnerInsightsItem>? Items { get; init; } = default!;

}
