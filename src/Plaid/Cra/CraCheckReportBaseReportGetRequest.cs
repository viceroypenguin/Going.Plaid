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
	public string? UserToken { get; set; } = default!;

	/// <summary>
	/// <para>The third-party user token associated with the requested User data.</para>
	/// </summary>
	[JsonPropertyName("third_party_user_token")]
	public string? ThirdPartyUserToken { get; set; } = default!;

	/// <summary>
	/// <para>The item IDs to include in the Base Report. If not provided, all items associated with the user will be included.</para>
	/// </summary>
	[JsonPropertyName("item_ids")]
	public IReadOnlyList<string>? ItemIds { get; set; } = default!;

}
