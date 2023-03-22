namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the request schema for <c>/transfer/metrics/get</c></para>
/// </summary>
public partial class TransferMetricsGetRequest : RequestBase
{
	/// <summary>
	/// <para>The Plaid client ID of the transfer originator. Should only be present if <c>client_id</c> is a third-party sender (TPS).</para>
	/// </summary>
	[JsonPropertyName("originator_client_id")]
	public string? OriginatorClientId { get; set; } = default!;
}