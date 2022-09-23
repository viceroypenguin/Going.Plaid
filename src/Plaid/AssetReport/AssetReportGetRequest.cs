namespace Going.Plaid.AssetReport;

/// <summary>
/// <para>AssetReportGetRequest defines the request schema for <c>/asset_report/get</c></para>
/// </summary>
public partial class AssetReportGetRequest : RequestBase
{
	/// <summary>
	/// <para>A token that can be provided to endpoints such as <c>/asset_report/get</c> or <c>/asset_report/pdf/get</c> to fetch or update an Asset Report.</para>
	/// </summary>
	[JsonPropertyName("asset_report_token")]
	public string AssetReportToken { get; set; } = default!;

	/// <summary>
	/// <para><c>true</c> if you would like to retrieve the Asset Report with Insights, <c>false</c> otherwise. This field defaults to <c>false</c> if omitted.</para>
	/// </summary>
	[JsonPropertyName("include_insights")]
	public bool IncludeInsights { get; set; } = default!;

	/// <summary>
	/// <para><c>true</c> to fetch "fast" version of asset report. Defaults to false if omitted.</para>
	/// </summary>
	[JsonPropertyName("fast_report")]
	public bool FastReport { get; set; } = default!;

	/// <summary>
	/// <para>An optional object to filter or add data to <c>/asset_report/get</c> results. If provided, must be non-<c>null</c>.</para>
	/// </summary>
	[JsonPropertyName("options")]
	public Entity.AssetReportGetRequestOptions Options { get; set; } = default!;
}