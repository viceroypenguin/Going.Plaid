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
	/// <para>Defines configuration options to generate Partner Insights</para>
	/// </summary>
	[JsonPropertyName("options")]
	public Entity.CraCheckReportPartnerInsightsGetOptions? Options { get; set; } = default!;

}
