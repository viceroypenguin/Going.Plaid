namespace Going.Plaid.AssetReport;

/// <summary>
/// <para>AssetReportRefreshRequest defines the request schema for <c>/asset_report/refresh</c></para>
/// </summary>
public partial class AssetReportRefreshRequest : RequestBase
{
	/// <summary>
	/// <para>The <c>asset_report_token</c> returned by the original call to <c>/asset_report/create</c></para>
	/// </summary>
	[JsonPropertyName("asset_report_token")]
	public string AssetReportToken { get; set; } = default!;

	/// <summary>
	/// <para>The maximum number of days of history to include in the Asset Report. Must be an integer. If not specified, the value from the original call to <c>/asset_report/create</c> will be used.</para>
	/// </summary>
	[JsonPropertyName("days_requested")]
	public int? DaysRequested { get; set; } = default!;

	/// <summary>
	/// <para>An optional object to filter <c>/asset_report/refresh</c> results. If provided, cannot be <c>null</c>. If not specified, the <c>options</c> from the original call to <c>/asset_report/create</c> will be used.</para>
	/// </summary>
	[JsonPropertyName("options")]
	public Entity.AssetReportRefreshRequestOptions? Options { get; set; } = default!;
}