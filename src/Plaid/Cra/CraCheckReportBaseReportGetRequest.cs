namespace Going.Plaid.Cra;

/// <summary>
/// <para>BaseReportGetRequest defines the request schema for <c>/cra/check_report/base_report/get</c></para>
/// </summary>
public partial class CraCheckReportBaseReportGetRequest : RequestBase
{
	/// <summary>
	/// <para>The user token associated with the User data is being requested for.</para>
	/// </summary>
	[JsonPropertyName("user_token")]
	public string UserToken { get; set; } = default!;

}
