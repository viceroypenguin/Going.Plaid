namespace Going.Plaid.BankTransfer;

/// <summary>
/// <para>Defines the response schema for <c>/bank_transfer/get</c></para>
/// </summary>
public record BankTransferGetResponse : ResponseBase
{
	/// <summary>
	/// <para>Represents a bank transfer within the Bank Transfers API.</para>
	/// </summary>
	[JsonPropertyName("bank_transfer")]
	public Entity.BankTransfer BankTransfer { get; init; } = default!;
}