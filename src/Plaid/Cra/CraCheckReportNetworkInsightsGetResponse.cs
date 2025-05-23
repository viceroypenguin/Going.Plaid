namespace Going.Plaid.Cra;

/// <summary>
/// <para>CraCheckReportNetworkInsightsGetResponse defines the response schema for <c>/cra/check_report/network_attributes/get</c>.</para>
/// </summary>
public record CraCheckReportNetworkInsightsGetResponse : ResponseBase
{
	/// <summary>
	/// <para>Contains data for the CRA Network Attributes Report.</para>
	/// </summary>
	[JsonPropertyName("report")]
	public Entity.CraNetworkInsightsReport Report { get; init; } = default!;

	/// <summary>
	/// <para>If the Network Insights generation was successful but a subset of data could not be retrieved, this array will contain information about the errors causing information to be missing</para>
	/// </summary>
	[JsonPropertyName("warnings")]
	public IReadOnlyList<Entity.CraReportWarning>? Warnings { get; init; } = default!;

}
