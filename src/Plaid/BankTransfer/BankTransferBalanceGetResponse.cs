namespace Going.Plaid.BankTransfer;

/// <summary>
/// <para>Defines the response schema for <c>/bank_transfer/balance/get</c></para>
/// </summary>
public record BankTransferBalanceGetResponse : ResponseBase
{
	/// <summary>
	/// <para>Information about the balance of a bank transfer</para>
	/// </summary>
	[JsonPropertyName("balance")]
	public Entity.BankTransferBalance Balance { get; init; } = default!;

	/// <summary>
	/// <para>The ID of the origination account that this balance belongs to.</para>
	/// </summary>
	[JsonPropertyName("origination_account_id")]
	public string? OriginationAccountId { get; init; } = default!;

}
