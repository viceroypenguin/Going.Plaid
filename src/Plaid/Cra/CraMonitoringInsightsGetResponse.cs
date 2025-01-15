namespace Going.Plaid.Cra;

/// <summary>
/// <para>CraMonitoringInsightsGetResponse defines the response schema for <c>cra/monitoring_insights/get</c></para>
/// </summary>
public record CraMonitoringInsightsGetResponse : ResponseBase
{
	/// <summary>
	/// <para>A unique ID identifying a User Monitoring Insights Report. Like all Plaid identifiers, this ID is case sensitive.</para>
	/// </summary>
	[JsonPropertyName("user_insights_id")]
	public string UserInsightsId { get; init; } = default!;

	/// <summary>
	/// <para>An array of Monitoring Insights Items associated with the user.</para>
	/// </summary>
	[JsonPropertyName("items")]
	public IReadOnlyList<Entity.CraMonitoringInsightsItem> Items { get; init; } = default!;

}
