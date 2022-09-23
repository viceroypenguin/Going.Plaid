namespace Going.Plaid.Entity;

/// <summary>
/// <para>An optional object to filter or add data to <c>/asset_report/get</c> results. If provided, must be non-<c>null</c>.</para>
/// </summary>
public class AssetReportGetRequestOptions
{
	/// <summary>
	/// <para>The maximum integer number of days of history to include in the Asset Report.</para>
	/// </summary>
	[JsonPropertyName("days_to_include")]
	public int? DaysToInclude { get; set; } = default!;
}