namespace Going.Plaid.Credit;

/// <summary>
/// <para>CreditRelayRefreshResponse defines the response schema for <c>/credit/relay/refresh</c></para>
/// </summary>
public record CreditRelayRefreshResponse : ResponseBase
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("relay_token")]
	public string RelayToken { get; init; } = default!;

	/// <summary>
	/// <para>A unique ID identifying an Asset Report. Like all Plaid identifiers, this ID is case sensitive.</para>
	/// </summary>
	[JsonPropertyName("asset_report_id")]
	public string? AssetReportId { get; init; } = default!;

}
