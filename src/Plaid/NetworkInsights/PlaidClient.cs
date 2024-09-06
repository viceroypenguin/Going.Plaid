namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>This endpoint allows you to retrieve the Network Insights from a list of <c>access_tokens</c>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/network_insights/report/#get" /></remarks>
	public Task<NetworkInsights.NetworkInsightsReportGetResponse> NetworkInsightsReportGetAsync(NetworkInsights.NetworkInsightsReportGetRequest request) =>
		PostAsync("/network_insights/report/get", request)
			.ParseResponseAsync<NetworkInsights.NetworkInsightsReportGetResponse>();

}
