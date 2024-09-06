namespace Going.Plaid.NetworkInsights;

/// <summary>
/// <para>NetworkInsightsReportGetRequest defines the request schema for <c>/network_insights/report/get</c>.</para>
/// </summary>
public partial class NetworkInsightsReportGetRequest : RequestBase
{
	/// <summary>
	/// <para>A list of access tokens that the Network Insights will be requested for. These correspond to previous Items a user has connected.</para>
	/// </summary>
	[JsonPropertyName("access_tokens")]
	public IReadOnlyList<string> AccessTokens { get; set; } = default!;

}
