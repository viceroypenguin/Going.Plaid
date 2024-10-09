namespace Going.Plaid.Cra;

/// <summary>
/// <para>CraCheckReportNetworkInsightsGetRequest defines the request schema for <c>/cra/check_report/network_attributes/get</c>.</para>
/// </summary>
public partial class CraCheckReportNetworkInsightsGetRequest : RequestBase
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

}
