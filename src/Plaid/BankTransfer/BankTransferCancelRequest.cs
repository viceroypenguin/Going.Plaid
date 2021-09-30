namespace Going.Plaid.BankTransfer;

/// <summary>
/// <para>Defines the request schema for <c>/bank_transfer/cancel</c></para>
/// </summary>
public class BankTransferCancelRequest : RequestBase
{
	/// <summary>
	/// <para>Plaid’s unique identifier for a bank transfer.</para>
	/// </summary>
	[JsonPropertyName("bank_transfer_id")]
	public string BankTransferId { get; set; } = default!;
}