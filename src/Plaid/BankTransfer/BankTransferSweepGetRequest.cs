namespace Going.Plaid.BankTransfer;

/// <summary>
/// <para>BankTransferSweepGetRequest defines the request schema for <c>/bank_transfer/sweep/get</c></para>
/// </summary>
public partial class BankTransferSweepGetRequest : RequestBase
{
	/// <summary>
	/// <para>Identifier of the sweep.</para>
	/// </summary>
	[JsonPropertyName("sweep_id")]
	public int SweepId { get; set; } = default!;

	/// <summary>
	/// <para>If multiple origination accounts are available, <c>origination_account_id</c> must be used to specify the account that the sweep belongs to.</para>
	/// </summary>
	[JsonPropertyName("origination_account_id")]
	public string? OriginationAccountId { get; set; } = default!;
}