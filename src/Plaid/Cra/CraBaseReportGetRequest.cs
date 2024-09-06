namespace Going.Plaid.Cra;

/// <summary>
/// <para>CraBaseReportGetRequest defines the request schema for <c>/cra/base_report/get</c></para>
/// </summary>
public partial class CraBaseReportGetRequest : RequestBase
{
	/// <summary>
	/// <para>The user token associated with the User data is being requested for.</para>
	/// </summary>
	[JsonPropertyName("user_token")]
	public string UserToken { get; set; } = default!;

}
