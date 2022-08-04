namespace Going.Plaid.Credit;

/// <summary>
/// <para>CreditRelayGetRequest defines the request schema for <c>/credit/relay/get</c></para>
/// </summary>
public partial class CreditRelayGetRequest : RequestBase
{
	/// <summary>
	/// <para>The <c>relay_token</c> granting access to the report you would like to get.</para>
	/// </summary>
	[JsonPropertyName("relay_token")]
	public string RelayToken { get; set; } = default!;

	/// <summary>
	/// <para>The report type. It can be <c>assets</c> or <c>income</c>.</para>
	/// </summary>
	[JsonPropertyName("report_type")]
	public Entity.ReportType ReportType { get; set; } = default!;
}