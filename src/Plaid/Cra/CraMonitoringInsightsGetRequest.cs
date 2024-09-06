namespace Going.Plaid.Cra;

/// <summary>
/// <para>CraMonitoringInsightsGetRequest defines the request schema for <c>/cra/monitoring_insights/get</c></para>
/// </summary>
public partial class CraMonitoringInsightsGetRequest : RequestBase
{
	/// <summary>
	/// <para>The user token associated with the User data is being requested for.</para>
	/// </summary>
	[JsonPropertyName("user_token")]
	public string UserToken { get; set; } = default!;

}
