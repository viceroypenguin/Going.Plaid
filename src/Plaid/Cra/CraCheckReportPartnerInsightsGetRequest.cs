namespace Going.Plaid.Cra;

/// <summary>
/// <para>CraPartnerInsightsGetRequest defines the request schema for <c>/cra/partner_insights/get</c>.</para>
/// </summary>
public partial class CraCheckReportPartnerInsightsGetRequest : RequestBase
{
	/// <summary>
	/// <para>The user token associated with the User data is being requested for.</para>
	/// </summary>
	[JsonPropertyName("user_token")]
	public string? UserToken { get; set; } = default!;

	/// <summary>
	/// <para>The third-party user token associated with the requested User data.</para>
	/// </summary>
	[JsonPropertyName("third_party_user_token")]
	public string? ThirdPartyUserToken { get; set; } = default!;

	/// <summary>
	/// <para>Defines configuration to generate Partner Insights</para>
	/// </summary>
	[JsonPropertyName("partner_insights")]
	public Entity.CraCheckReportPartnerInsightsGetPartnerInsights? PartnerInsights { get; set; } = default!;

	/// <summary>
	/// <para>Deprecated, specify <c>partner_insights.prism_versions</c> instead.</para>
	/// </summary>
	[JsonPropertyName("options")]
	[Obsolete]
	public Entity.CraCheckReportPartnerInsightsGetOptions? Options { get; set; } = default!;

}
