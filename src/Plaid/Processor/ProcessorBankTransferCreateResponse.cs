namespace Going.Plaid.Processor;

/// <summary>
/// <para>ProcessorBankTransferCreateResponse defines the response schema for <c>/processor/bank_transfer/create</c></para>
/// </summary>
public record ProcessorBankTransferCreateResponse : ResponseBase
{
	/// <summary>
	/// <para>Represents a bank transfer within the Bank Transfers API.</para>
	/// </summary>
	[JsonPropertyName("bank_transfer")]
	public Entity.BankTransfer BankTransfer { get; init; } = default!;
}