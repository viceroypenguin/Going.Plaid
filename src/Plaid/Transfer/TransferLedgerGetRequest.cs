namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the request schema for <c>/transfer/ledger/get</c></para>
/// </summary>
public partial class TransferLedgerGetRequest : RequestBase
{
	/// <summary>
	/// <para>Specify which ledger balance to get. Customers can find a list of <c>ledger_id</c>s in the Accounts page of your Plaid Dashboard. If this field is left blank, this will default to id of the default ledger balance.</para>
	/// </summary>
	[JsonPropertyName("ledger_id")]
	public string? LedgerId { get; set; } = default!;

	/// <summary>
	/// <para>Client ID of the end customer.</para>
	/// </summary>
	[JsonPropertyName("originator_client_id")]
	public string? OriginatorClientId { get; set; } = default!;

}
