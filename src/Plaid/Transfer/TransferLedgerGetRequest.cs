namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the request schema for <c>/transfer/ledger/get</c></para>
/// </summary>
public partial class TransferLedgerGetRequest : RequestBase
{
	/// <summary>
	/// <para>Client ID of the end customer.</para>
	/// </summary>
	[JsonPropertyName("originator_client_id")]
	public string? OriginatorClientId { get; set; } = default!;
}