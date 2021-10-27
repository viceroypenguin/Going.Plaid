namespace Going.Plaid.AssetReport;

/// <summary>
/// <para>AssetReportCreateResponse defines the response schema for <c>/asset_report/create</c></para>
/// </summary>
public record AssetReportCreateResponse : ResponseBase
{
	/// <summary>
	/// <para>A token that can be provided to endpoints such as <c>/asset_report/get</c> or <c>/asset_report/pdf/get</c> to fetch or update an Asset Report.</para>
	/// </summary>
	[JsonPropertyName("asset_report_token")]
	public string AssetReportToken { get; init; } = default!;

	/// <summary>
	/// <para>A unique ID identifying an Asset Report. Like all Plaid identifiers, this ID is case sensitive.</para>
	/// </summary>
	[JsonPropertyName("asset_report_id")]
	public string AssetReportId { get; init; } = default!;
}