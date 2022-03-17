namespace Going.Plaid.AssetReport;

/// <summary>
/// <para>AssetReportRelayRemoveRequest defines the request schema for <c>/asset_report/relay/remove</c></para>
/// </summary>
public partial class AssetReportRelayRemoveRequest : RequestBase
{
	/// <summary>
	/// <para>The <c>asset_relay_token</c> you would like to revoke.</para>
	/// </summary>
	[JsonPropertyName("asset_relay_token")]
	public string AssetRelayToken { get; set; } = default!;
}