namespace Going.Plaid.Credit;

/// <summary>
/// <para>CreditRelayRefreshRequest defines the request schema for <c>/credit/relay/refresh</c></para>
/// </summary>
public partial class CreditRelayRefreshRequest : RequestBase
{
	/// <summary>
	/// <para>The <c>relay_token</c> granting access to the report you would like to refresh.</para>
	/// </summary>
	[JsonPropertyName("relay_token")]
	public string RelayToken { get; set; } = default!;

	/// <summary>
	/// <para>The report type. It can be <c>asset</c>. Income report types are not yet supported.</para>
	/// </summary>
	[JsonPropertyName("report_type")]
	public Entity.ReportType ReportType { get; set; } = default!;

	/// <summary>
	/// <para>The URL registered to receive webhooks when the report of a relay token has been refreshed.</para>
	/// </summary>
	[JsonPropertyName("webhook")]
	public string? Webhook { get; set; } = default!;

}
