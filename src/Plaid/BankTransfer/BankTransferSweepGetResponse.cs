namespace Going.Plaid.BankTransfer;

/// <summary>
/// <para>BankTransferSweepGetResponse defines the response schema for <c>/bank_transfer/sweep/get</c></para>
/// </summary>
public record BankTransferSweepGetResponse : ResponseBase
{
	/// <summary>
	/// <para>BankTransferSweep describes a sweep transfer.</para>
	/// </summary>
	[JsonPropertyName("sweep")]
	public Entity.BankTransferSweep Sweep { get; init; } = default!;

}
