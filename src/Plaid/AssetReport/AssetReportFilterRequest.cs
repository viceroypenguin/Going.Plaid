namespace Going.Plaid.AssetReport;

/// <summary>
/// <para>AssetReportFilterRequest defines the request schema for <c>/asset_report/filter</c></para>
/// </summary>
public partial class AssetReportFilterRequest : RequestBase
{
	/// <summary>
	/// <para>A token that can be provided to endpoints such as <c>/asset_report/get</c> or <c>/asset_report/pdf/get</c> to fetch or update an Asset Report.</para>
	/// </summary>
	[JsonPropertyName("asset_report_token")]
	public string AssetReportToken { get; set; } = default!;

	/// <summary>
	/// <para>The accounts to exclude from the Asset Report, identified by <c>account_id</c>.</para>
	/// </summary>
	[JsonPropertyName("account_ids_to_exclude")]
	public IReadOnlyList<string> AccountIdsToExclude { get; set; } = default!;
}