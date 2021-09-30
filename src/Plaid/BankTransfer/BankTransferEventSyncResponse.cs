namespace Going.Plaid.BankTransfer;

/// <summary>
/// <para>Defines the response schema for <c>/bank_transfer/event/sync</c></para>
/// </summary>
public record BankTransferEventSyncResponse : ResponseBase
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("bank_transfer_events")]
	public IReadOnlyList<Entity.BankTransferEvent> BankTransferEvents { get; init; } = default!;
}