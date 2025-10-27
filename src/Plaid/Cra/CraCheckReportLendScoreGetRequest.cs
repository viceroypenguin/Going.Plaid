namespace Going.Plaid.Cra;

/// <summary>
/// <para>CraCheckReportLendScoreGetRequest defines the request schema for <c>/cra/check_report/lend_score/get</c>.</para>
/// </summary>
public partial class CraCheckReportLendScoreGetRequest : RequestBase
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
	/// <para>Defines configuration options to generate the LendScore</para>
	/// </summary>
	[JsonPropertyName("options")]
	public Entity.CraCheckReportLendScoreGetOptions? Options { get; set; } = default!;

}
