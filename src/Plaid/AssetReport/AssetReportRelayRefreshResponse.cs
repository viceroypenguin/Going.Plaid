namespace Going.Plaid.AssetReport;

/// <summary>
/// <para>AssetReportRelayRefreshResponse defines the response schema for <c>/asset_report/relay/refresh</c></para>
/// </summary>
public record AssetReportRelayRefreshResponse : ResponseBase
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("asset_relay_token")]
	public string AssetRelayToken { get; init; } = default!;

	/// <summary>
	/// <para>A unique ID identifying an Asset Report. Like all Plaid identifiers, this ID is case sensitive.</para>
	/// </summary>
	[JsonPropertyName("asset_report_id")]
	public string AssetReportId { get; init; } = default!;
}