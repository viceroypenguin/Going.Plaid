namespace Going.Plaid.AssetReport;

/// <summary>
/// <para>AssetReportRelayGetRequest defines the request schema for <c>/asset_report/relay/get</c></para>
/// </summary>
public partial class AssetReportRelayGetRequest : RequestBase
{
	/// <summary>
	/// <para>The <c>asset_relay_token</c> granting access to the Asset Report you would like to get.</para>
	/// </summary>
	[JsonPropertyName("asset_relay_token")]
	public string AssetRelayToken { get; set; } = default!;
}