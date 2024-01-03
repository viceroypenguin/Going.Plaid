namespace Going.Plaid.BankTransfer;

/// <summary>
/// <para>Defines the request schema for <c>/bank_transfer/sweep/get</c></para>
/// </summary>
public partial class BankTransferSweepGetRequest : RequestBase
{
	/// <summary>
	/// <para>Identifier of the sweep.</para>
	/// </summary>
	[JsonPropertyName("sweep_id")]
	public string SweepId { get; set; } = default!;

}
