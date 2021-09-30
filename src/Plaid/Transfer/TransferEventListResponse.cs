namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the response schema for <c>/transfer/event/list</c></para>
/// </summary>
public record TransferEventListResponse : ResponseBase
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("transfer_events")]
	public IReadOnlyList<Entity.TransferEvent> TransferEvents { get; init; } = default!;
}