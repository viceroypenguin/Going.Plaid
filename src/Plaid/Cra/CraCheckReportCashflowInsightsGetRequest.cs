namespace Going.Plaid.Cra;

/// <summary>
/// <para>CraCheckReportCashflowInsightsGetRequest defines the request schema for <c>/cra/check_report/cashflow_insights/get</c>.</para>
/// </summary>
public partial class CraCheckReportCashflowInsightsGetRequest : RequestBase
{
	/// <summary>
	/// <para>The user token associated with the User data is being requested for.</para>
	/// </summary>
	[JsonPropertyName("user_token")]
	public string? UserToken { get; set; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("user_id")]
	public string? UserId { get; set; } = default!;

	/// <summary>
	/// <para>The third-party user token associated with the requested User data.</para>
	/// </summary>
	[JsonPropertyName("third_party_user_token")]
	public string? ThirdPartyUserToken { get; set; } = default!;

	/// <summary>
	/// <para>Defines configuration options to generate Cashflow Insights</para>
	/// </summary>
	[JsonPropertyName("options")]
	public Entity.CraCheckReportCashflowInsightsGetOptions? Options { get; set; } = default!;

}
