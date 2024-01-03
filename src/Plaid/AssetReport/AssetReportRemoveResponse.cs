namespace Going.Plaid.AssetReport;

/// <summary>
/// <para>AssetReportRemoveResponse defines the response schema for <c>/asset_report/remove</c></para>
/// </summary>
public record AssetReportRemoveResponse : ResponseBase
{
	/// <summary>
	/// <para><c>true</c> if the Asset Report was successfully removed.</para>
	/// </summary>
	[JsonPropertyName("removed")]
	public bool Removed { get; init; } = default!;

}
