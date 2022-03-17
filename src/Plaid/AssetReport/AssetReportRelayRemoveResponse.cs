namespace Going.Plaid.AssetReport;

/// <summary>
/// <para>AssetReportRelayRemoveResponse defines the response schema for <c>/asset_report/relay/remove</c></para>
/// </summary>
public record AssetReportRelayRemoveResponse : ResponseBase
{
	/// <summary>
	/// <para><c>true</c> if the Asset Relay token was successfully removed.</para>
	/// </summary>
	[JsonPropertyName("removed")]
	public bool Removed { get; init; } = default!;
}