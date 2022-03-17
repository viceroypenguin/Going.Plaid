namespace Going.Plaid.AssetReport;

/// <summary>
/// <para>AssetReportRelayCreateRequest defines the request schema for <c>/asset_report/relay/create</c></para>
/// </summary>
public partial class AssetReportRelayCreateRequest : RequestBase
{
	/// <summary>
	/// <para>A token that can be provided to endpoints such as <c>/asset_report/get</c> or <c>/asset_report/pdf/get</c> to fetch or update an Asset Report.</para>
	/// </summary>
	[JsonPropertyName("asset_report_token")]
	public string AssetReportToken { get; set; } = default!;

	/// <summary>
	/// <para>The <c>secondary_client_id</c> is the client id of the third party with whom you would like to share the Asset Report.</para>
	/// </summary>
	[JsonPropertyName("secondary_client_id")]
	public string SecondaryClientId { get; set; } = default!;

	/// <summary>
	/// <para>URL to which Plaid will send webhooks when the Secondary Client successfully retrieves an Asset Report by calling <c>asset_report/relay/get</c>.</para>
	/// </summary>
	[JsonPropertyName("webhook")]
	public string? Webhook { get; set; } = default!;
}