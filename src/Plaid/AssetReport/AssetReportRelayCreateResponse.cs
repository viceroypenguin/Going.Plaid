namespace Going.Plaid.AssetReport;

/// <summary>
/// <para>AssetReportRelayCreateResponse defines the response schema for <c>/asset_report/relay/create</c></para>
/// </summary>
public record AssetReportRelayCreateResponse : ResponseBase
{
	/// <summary>
	/// <para>A token that can be shared with a third party to allow them to access the Asset Report. This token should be stored securely.</para>
	/// </summary>
	[JsonPropertyName("asset_relay_token")]
	public string AssetRelayToken { get; init; } = default!;
}