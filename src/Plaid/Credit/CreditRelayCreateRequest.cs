namespace Going.Plaid.Credit;

/// <summary>
/// <para>CreditRelayCreateRequest defines the request schema for <c>/credit/relay/create</c></para>
/// </summary>
public partial class CreditRelayCreateRequest : RequestBase
{
	/// <summary>
	/// <para>List of report token strings, with at most one token of each report type. Currently only Asset Report token is supported.</para>
	/// </summary>
	[JsonPropertyName("report_tokens")]
	public IReadOnlyList<string> ReportTokens { get; set; } = default!;

	/// <summary>
	/// <para>The <c>secondary_client_id</c> is the client id of the third party with whom you would like to share the Relay Token.</para>
	/// </summary>
	[JsonPropertyName("secondary_client_id")]
	public string SecondaryClientId { get; set; } = default!;

	/// <summary>
	/// <para>URL to which Plaid will send webhooks when the Secondary Client successfully retrieves an Asset Report by calling <c>/credit/relay/get</c>.</para>
	/// </summary>
	[JsonPropertyName("webhook")]
	public string? Webhook { get; set; } = default!;
}