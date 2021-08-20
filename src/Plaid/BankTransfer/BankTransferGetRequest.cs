namespace Going.Plaid.BankTransfer;

/// <summary>
/// <para>BankTransferGetRequest defines the request schema for <c>/bank_transfer/get</c></para>
/// </summary>
public class BankTransferGetRequest : RequestBase
{
	/// <summary>
	/// <para>Plaid’s unique identifier for a bank transfer.</para>
	/// </summary>
	[JsonPropertyName("bank_transfer_id")]
	public string BankTransferId { get; set; } = default!;
}