namespace Going.Plaid.BankTransfer;

/// <summary>
/// <para>BankTransferBalanceGetRequest defines the request schema for <c>/bank_transfer/balance/get</c></para>
/// </summary>
public class BankTransferBalanceGetRequest : RequestBase
{
	/// <summary>
	/// <para>If multiple origination accounts are available, <c>origination_account_id</c> must be used to specify the account for which balance will be returned.</para>
	/// </summary>
	[JsonPropertyName("origination_account_id")]
	public string? OriginationAccountId { get; set; } = default!;
}