namespace Going.Plaid.Cra;

/// <summary>
/// <para>Defines the request schema for <c>/cra/check_report/income_insights/get</c>.</para>
/// </summary>
public partial class CraCheckReportIncomeInsightsGetRequest : RequestBase
{
	/// <summary>
	/// <para>The user token associated with the User data is being requested for.</para>
	/// </summary>
	[JsonPropertyName("user_token")]
	public string UserToken { get; set; } = default!;

}
