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

}
