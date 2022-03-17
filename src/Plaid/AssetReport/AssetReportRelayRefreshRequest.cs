namespace Going.Plaid.AssetReport;

/// <summary>
/// <para>AssetReportRelayRefreshRequest defines the request schema for <c>/asset_report/relay/refresh</c></para>
/// </summary>
public partial class AssetReportRelayRefreshRequest : RequestBase
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("asset_relay_token")]
	public string AssetRelayToken { get; set; } = default!;

	/// <summary>
	/// <para>The URL registered to receive webhooks when the Asset Report of a Relay Token has been refreshed.</para>
	/// </summary>
	[JsonPropertyName("webhook")]
	public string? Webhook { get; set; } = default!;
}